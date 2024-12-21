using System.Security.Claims;
using AutoMapper;
using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Cart;
using BusinessLayer.DTOs.Review;
using BusinessLayer.DTOs.WishlistItem;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebMVC.Models;
using WebMVC.Models.Author;
using WebMVC.Models.Book;
using WebMVC.Models.Cart;
using WebMVC.Models.Genre;
using WebMVC.Models.Publisher;
using WebMVC.Models.Review;
using WebMVC.Models.Wishlist;

namespace WebMVC.Controllers;

[Route("books")]
public class BookController : Controller
{
    private readonly IBookService _bookService;
    private readonly IMapper _mapper;
    private readonly ICartItemService _cartItemService;
    private readonly IWishlistItemService _wishlistItemService;
    private readonly IReviewService _reviewService;
    private readonly IAuthorService _authorService;
    private readonly IPublisherService _publisherService;
    private readonly IGenreService _genreService;
    private readonly IMemoryCache _memoryCache;
    private readonly ILogger<BookController> _logger;

    public BookController(
        IBookService bookService,
        IMapper mapper,
        ICartItemService cartItemService,
        IWishlistItemService wishlistItemService,
        IReviewService reviewService,
        IAuthorService authorService,
        IPublisherService publisherService,
        IGenreService genreService,
        IMemoryCache memoryCache,
        ILogger<BookController> logger
    )
    {
        _bookService = bookService;
        _mapper = mapper;
        _cartItemService = cartItemService;
        _wishlistItemService = wishlistItemService;
        _reviewService = reviewService;
        _authorService = authorService;
        _publisherService = publisherService;
        _genreService = genreService;
        _memoryCache = memoryCache;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Index(
        BookFilterViewModel filters,
        int page = 1,
        int pageSize = 6
    )
    {
        var filterDto = _mapper.Map<BookFilterDto>(filters);
        var books = await _bookService.GetFilteredBooksAsync(filterDto, page, pageSize);
        var genreDtos = await _genreService.GetAllGenresAsync();
        var genres = _mapper.Map<IEnumerable<GenreViewModel>>(genreDtos);
        var paginatedViewModel = _mapper.Map<PaginatedViewModel<BookViewModel>>(books);

        return View(
            new BookCompositeViewModel()
            {
                Pagination = paginatedViewModel,
                Filters = filters,
                Genres = genres,
            }
        );
    }

    [HttpPost]
    public IActionResult Index(BookCompositeViewModel compositeViewModel)
    {
        return RedirectToAction(
            nameof(Index),
            new BookFilterViewModel()
            {
                Name = compositeViewModel.Filters.Name,
                MinPrice = compositeViewModel.Filters.MinPrice,
                MaxPrice = compositeViewModel.Filters.MaxPrice,
                GenreId = compositeViewModel.Filters.GenreId,
                Publisher = compositeViewModel.Filters.Publisher,
            }
        );
    }

    [Route("detail/{id}")]
    public async Task<IActionResult> Detail(int id)
    {
        var cacheKey = $"BookDetail_{id}";

        if (!_memoryCache.TryGetValue(cacheKey, out BookDetailViewModel? bookDetailViewModel))
        {
            _logger.LogInformation($"Cache miss for {cacheKey} at {DateTime.Now}");
            var bookDto = await _bookService.GetBookByIdAsync(id);
            bookDetailViewModel = _mapper.Map<BookDetailViewModel>(bookDto);

            _memoryCache.Set(cacheKey, bookDetailViewModel, TimeSpan.FromMinutes(10));
        }
        else
        {
            _logger.LogInformation($"Cache hit for {cacheKey} at {DateTime.Now}");
        }
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (int.TryParse(userIdClaim, out int userId))
        {
            bookDetailViewModel!.IsWishlisted = await _wishlistItemService.IsWishlistedAsync(
                userId,
                id
            );
        }

        return View(bookDetailViewModel);
    }

    [Authorize]
    [HttpPost]
    [Route("add-to-cart")]
    public async Task<IActionResult> AddToCart(CreateCartItemViewModel cartItem)
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (int.TryParse(userIdClaim, out int userId))
        {
            var createDto = _mapper.Map<CreateCartItemDto>(cartItem);
            await _cartItemService.CreateCartItemAsync(userId, createDto);
            TempData["Success"] = "Book added to the cart successfully!";
        }

        return RedirectToAction(nameof(Detail), "Book", new { Id = cartItem.BookId });
    }

    [Authorize]
    [HttpPost]
    [Route("add-to-wishlist")]
    public async Task<IActionResult> AddToWishlist(CreateWishlistItemViewModel wishlist)
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (int.TryParse(userIdClaim, out int userId))
        {
            var wishlistDto = _mapper.Map<CreateWishlistItemDto>(wishlist);
            await _wishlistItemService.CreateWishlistItemAsync(userId, wishlistDto);

            _memoryCache.Remove($"BookDetail_{wishlist.BookId}");

            TempData["Success"] = "Book added to the wishlist successfully!";
        }
        return RedirectToAction(nameof(Detail), "Book", new { Id = wishlist.BookId });
    }

    [Authorize]
    [Route("{bookId}/add-review")]
    public IActionResult AddReview(int bookId)
    {
        var createReviewViewModel = new CreateReviewViewModel() { BookId = bookId };
        return View(createReviewViewModel);
    }

    [Authorize]
    [HttpPost]
    [Route("{bookId}/add-review")]
    public async Task<IActionResult> AddReview(
        int bookId,
        CreateReviewViewModel createReviewViewModel
    )
    {
        if (!ModelState.IsValid)
        {
            return View(createReviewViewModel);
        }
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (int.TryParse(userIdClaim, out int userId))
        {
            createReviewViewModel.UserId = userId;
            var createReviewDto = _mapper.Map<CreateReviewDto>(createReviewViewModel);
            await _reviewService.CreateReviewAsync(createReviewDto);

            _memoryCache.Remove($"BookDetail_{bookId}");

            TempData["Success"] = "Review added to the book successfully!";
        }
        return RedirectToAction(nameof(Detail), "Book", new { Id = createReviewViewModel.BookId });
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("{bookId}/delete-review/{reviewId}")]
    public async Task<IActionResult> DeleteReview(int bookId, int reviewId)
    {
        await _reviewService.DeleteReviewAsync(reviewId);

        _memoryCache.Remove($"BookDetail_{bookId}");

        TempData["Success"] = "Review deleted successfully!";
        return RedirectToAction(nameof(Detail), "Book", new { Id = bookId });
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("{id}/delete")]
    public async Task<IActionResult> Delete(int id)
    {
        await _bookService.DeleteBookAsync(id);

        _memoryCache.Remove($"BookDetail_{id}");

        TempData["Success"] = "Book has been deleted successfully!";
        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    [Route("{id}/edit")]
    public async Task<IActionResult> Edit(int id)
    {
        var bookDto = await _bookService.GetBookByIdAsync(id);
        var book = _mapper.Map<BookViewModel>(bookDto);
        var authorDtos = await _authorService.GetAllAuthorsAsync();
        var publisherDtos = await _publisherService.GetAllPublishersAsync();
        var genreDtos = await _genreService.GetAllGenresAsync();
        var authors = _mapper.Map<IEnumerable<AuthorViewModel>>(authorDtos);
        var genres = _mapper.Map<IEnumerable<GenreViewModel>>(genreDtos);
        var publishers = _mapper.Map<IEnumerable<PublisherViewModel>>(publisherDtos);
        return View(
            new EditBookCompositeViewModel()
            {
                Items = new BookDropDownListItems()
                {
                    Authors = authors,
                    Publishers = publishers,
                    Genres = genres,
                },
                Book = _mapper.Map<EditBookViewModel>(book),
            }
        );
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("{id}/edit")]
    public async Task<IActionResult> Edit(int id, EditBookCompositeViewModel compositeViewModel)
    {
        var updateBookDto = _mapper.Map<UpdateBookDto>(compositeViewModel.Book);
        await _bookService.UpdateBookAsync(id, updateBookDto, compositeViewModel.Image);

        _memoryCache.Remove($"BookDetail_{id}");

        TempData["Success"] = "Book has been updated successfully!";
        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    [Route("create")]
    public async Task<IActionResult> Create()
    {
        var authorDtos = await _authorService.GetAllAuthorsAsync();
        var publisherDtos = await _publisherService.GetAllPublishersAsync();
        var genreDtos = await _genreService.GetAllGenresAsync();
        var authors = _mapper.Map<IEnumerable<AuthorViewModel>>(authorDtos);
        var genres = _mapper.Map<IEnumerable<GenreViewModel>>(genreDtos);
        var publishers = _mapper.Map<IEnumerable<PublisherViewModel>>(publisherDtos);
        return View(
            new CreateBookCompositeViewModel()
            {
                Items = new BookDropDownListItems()
                {
                    Authors = authors,
                    Publishers = publishers,
                    Genres = genres,
                },
                Book = new CreateBookViewModel(),
            }
        );
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> Create(CreateBookCompositeViewModel compositeViewModel)
    {
        var addBookDto = _mapper.Map<AddBookDto>(compositeViewModel.Book);
        await _bookService.AddBookAsync(addBookDto, compositeViewModel.Image);
        TempData["Success"] = "Book has been created successfully!";
        return RedirectToAction(nameof(Index));
    }
}
