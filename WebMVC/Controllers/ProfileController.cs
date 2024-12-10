using System.Security.Claims;
using AutoMapper;
using BusinessLayer.DTOs.Cart;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Cart;
using WebMVC.Models.Order;
using WebMVC.Models.Wishlist;

namespace WebMVC.Controllers;

[Authorize]
[Route("profile")]
public class ProfileController : Controller
{
    private readonly IWishlistItemService _wishlistItemService;
    private readonly IOrderService _orderService;
    private readonly IMapper _mapper;
    private readonly ICartItemService _cartItemService;

    public ProfileController(
        IWishlistItemService wishlistItemService,
        IMapper mapper,
        IOrderService orderService,
        ICartItemService cartItemService
    )
    {
        _wishlistItemService = wishlistItemService;
        _mapper = mapper;
        _cartItemService = cartItemService;
        _orderService = orderService;
    }

    [Route("wishlist")]
    public async Task<IActionResult> Wishlist()
    {
        var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (int.TryParse(userIdClaim, out int userId))
        {
            var wishlistItems = await _wishlistItemService.GetAllWishlistItemsAsync(userId);
            var mappedWishlistItems = _mapper.Map<List<WishlistItemViewModel>>(wishlistItems);
            return View(mappedWishlistItems);
        }

        return View();
    }

    [Route("cart")]
    public async Task<IActionResult> Cart()
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (int.TryParse(userIdClaim, out int userId))
        {
            var cartItems = await _cartItemService.GetAllCartItemsByUserAsync(userId);
            var cartViewModel = _mapper.Map<CartViewModel>(cartItems);
            return View(cartViewModel);
        }

        return View();
    }

    [HttpPost]
    [Route("delete-from-wishlist")]
    public async Task<IActionResult> DeleteFromWishlist(int id)
    {
        var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (int.TryParse(userIdClaim, out int userId))
        {
            await _wishlistItemService.DeleteWishlistItemAsync(userId, id);
        }
        return RedirectToAction(nameof(Wishlist));
    }

    [Route("orders")]
    public async Task<IActionResult> Orders()
    {
        var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (int.TryParse(userIdClaim, out int userId))
        {
            var orders = await _orderService.GetAllOrdersByUserIdAsync(userId);
            var mappedOrders = _mapper.Map<List<OrderViewModel>>(orders);
            return View(mappedOrders);
        }

        return View();
    }

    [Route("order-detail/{id:int}")]
    public async Task<IActionResult> OrderDetail(int id)
    {
        var order = await _orderService.GetOrderByIdAsync(id);
        var mappedOrder = _mapper.Map<OrderDetailViewModel>(order);
        return View(mappedOrder);
    }

    [Route("update-cart-item")]
    public async Task<IActionResult> UpdateCartItemDto(int id, UpdateCartItemViewModel cartItem)
    {
        var updateCartItemDto = _mapper.Map<UpdateCartItemDto>(cartItem);
        await _cartItemService.UpdateCartItemAsync(id, updateCartItemDto);
        return RedirectToAction(nameof(Cart), "Profile");
    }

    [HttpPost]
    [Route("delete-cart-item")]
    public async Task<IActionResult> DeleteCartItem(int id)
    {
        await _cartItemService.DeleteCartItemAsync(id);
        return RedirectToAction(nameof(Cart), "Profile");
    }
}
