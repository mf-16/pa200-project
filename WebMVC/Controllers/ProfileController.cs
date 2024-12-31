using System.Security.Claims;
using AutoMapper;
using BusinessLayer.DTOs.Cart;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Cart;
using WebMVC.Models.GiftCard;
using WebMVC.Models.Order;
using WebMVC.Models.Wishlist;

namespace WebMVC.Controllers;

[Authorize]
[Route("profile")]
public class ProfileController : Controller
{
    private readonly IWishlistItemService _wishlistItemService;
    private readonly IOrderService _orderService;
    private readonly IGiftCardService _giftCardService;
    private readonly IMapper _mapper;
    private readonly ICartItemService _cartItemService;

    public ProfileController(
        IWishlistItemService wishlistItemService,
        IMapper mapper,
        IOrderService orderService,
        ICartItemService cartItemService,
        IGiftCardService giftCardService
    )
    {
        _wishlistItemService = wishlistItemService;
        _mapper = mapper;
        _cartItemService = cartItemService;
        _giftCardService = giftCardService;
        _orderService = orderService;
    }

    [Route("wishlist")]
    public async Task<IActionResult> Wishlist()
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
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
            var cartItemDtos = await _cartItemService.GetAllCartItemsByUserAsync(userId);
            var couponDtos = await _giftCardService.GetAllCouponsByUserAsync(userId);
            var coupons = _mapper.Map<List<CouponViewModel>>(couponDtos);
            var cartItems = _mapper.Map<List<CartItemViewModel>>(cartItemDtos);
            return View(new CartViewModel() { CartItems = cartItems, Coupons = coupons });
        }

        return View();
    }

    [HttpPost]
    [Route("delete-from-wishlist")]
    public async Task<IActionResult> DeleteFromWishlist(int id)
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (int.TryParse(userIdClaim, out int userId))
        {
            await _wishlistItemService.DeleteWishlistItemAsync(userId, id);
        }
        return RedirectToAction(nameof(Wishlist));
    }

    [Route("orders")]
    public async Task<IActionResult> Orders()
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (int.TryParse(userIdClaim, out int userId))
        {
            var orders = await _orderService.GetAllOrdersByUserIdAsync(userId);
            var mappedOrders = _mapper.Map<List<OrderViewModel>>(orders);
            return View(mappedOrders);
        }

        return View();
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

    [HttpPost]
    [Route("apply-coupon")]
    public async Task<IActionResult> ApplyCoupon(string couponCode)
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (int.TryParse(userIdClaim, out int userId))
        {
            var couponDto = await _giftCardService.ApplyCouponAsync(userId, couponCode);

            if (couponDto == null)
            {
                TempData["Error"] = "Invalid coupon code.";
            }
            else
            {
                TempData["Success"] = "Coupon applied!";
            }
        }

        return RedirectToAction(nameof(Cart));
    }

    [HttpPost]
    [Route("remove-coupon/{id:int}")]
    public async Task<IActionResult> RemoveCoupon(int id)
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (int.TryParse(userIdClaim, out int userId))
        {
            await _giftCardService.RemoveCouponAsync(userId, id);
            TempData["Sucess"] = "Coupon removed";
        }

        return RedirectToAction(nameof(Cart));
    }
}
