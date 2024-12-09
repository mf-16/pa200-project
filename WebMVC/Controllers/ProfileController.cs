using AutoMapper;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Order;
using WebMVC.Models.Profile;

namespace WebMVC.Controllers;

[Authorize]
[Route("profile")]
public class ProfileController : Controller
{
    private readonly IWishlistItemService _wishlistItemService;
    private readonly IOrderService _orderService;
    private readonly IMapper _mapper;

    public ProfileController(IWishlistItemService wishlistItemService, IMapper mapper, IOrderService orderService)
    {
        _wishlistItemService = wishlistItemService;
        _mapper = mapper;
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
    
}