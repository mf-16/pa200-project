using System.Security.Claims;
using AutoMapper;
using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Cart;
using BusinessLayer.DTOs.WishlistItem;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using WebMVC.Models.Book;
using WebMVC.Models.Cart;
using WebMVC.Models.Wishlist;

namespace WebMVC.Controllers;

[Route("books")]
public class BookController : Controller
{
    private readonly IBookService _bookService;
    private readonly IMapper _mapper;
    private readonly ICartItemService _cartItemService;
    private readonly IWishlistItemService _wishlistItemService;

    public BookController(
        IBookService bookService,
        IMapper mapper,
        ICartItemService cartItemService,
        IWishlistItemService wishlistItemService
    )
    {
        _bookService = bookService;
        _mapper = mapper;
        _cartItemService = cartItemService;
        _wishlistItemService = wishlistItemService;
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
}
