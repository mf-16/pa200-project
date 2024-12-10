using System.Security.Claims;
using AutoMapper;
using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Cart;
using BusinessLayer.DTOs.Review;
using BusinessLayer.DTOs.WishlistItem;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using WebMVC.Models.Book;
using WebMVC.Models.Cart;
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

    public BookController(
        IBookService bookService,
        IMapper mapper,
        ICartItemService cartItemService,
        IWishlistItemService wishlistItemService,
        IReviewService reviewService
    )
    {
        _bookService = bookService;
        _mapper = mapper;
        _cartItemService = cartItemService;
        _wishlistItemService = wishlistItemService;
        _reviewService = reviewService;
    }

    public async Task<IActionResult> Index(
        BookFilterViewModel filter,
        int page = 1,
        int pageSize = 6
    )
    {
        var filterDto = _mapper.Map<BookFilterDto>(filter);
        var books = await _bookService.GetFilteredBooksAsync(filterDto, page, pageSize);
        var paginatedViewModel = _mapper.Map<PaginatedViewModel<BookViewModel>>(books);

        return View(
            new BookCompositeViewModel() { Pagination = paginatedViewModel, Filters = filter }
        );
    }

    [Route("detail/{id}")]
    public async Task<IActionResult> Detail(int id)
    {
        var bookDto = await _bookService.GetBookByIdAsync(id);
        var bookDetailViewModel = _mapper.Map<BookDetailViewModel>(bookDto);
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (int.TryParse(userIdClaim, out int userId))
        {
            bookDetailViewModel.IsWishlisted = await _wishlistItemService.IsWishlistedAsync(
                userId,
                bookDto.Id
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
        var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (int.TryParse(userIdClaim, out int userId))
        {
            createReviewViewModel.UserId = userId;
            var createReviewDto = _mapper.Map<CreateReviewDto>(createReviewViewModel);
            await _reviewService.CreateReviewAsync(createReviewDto);
            TempData["Success"] = "Review added to the book successfully!";
        }
        return RedirectToAction(nameof(Detail), "Book", new { Id = createReviewViewModel.BookId });
    }
}
