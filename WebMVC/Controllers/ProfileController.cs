using System.Security.Claims;
using AutoMapper;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Profile.Cart;

namespace WebMVC.Controllers;
[Authorize]
[Route("profile")]
public class ProfileController : Controller
{
    private readonly ICartItemService _cartItemService;
    private readonly IMapper _mapper;
    public ProfileController(ICartItemService cartItemService, IMapper mapper)
    {
        _cartItemService = cartItemService;
        _mapper = mapper;
    }

    [Route("cart")]
    public async Task<IActionResult> Cart()
    {
        
        var userIdClaim = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (int.TryParse(userIdClaim, out int userId))
        {
            var cartItems = await _cartItemService.GetAllCartItemsByUserAsync(userId);
            var cartViewModel = _mapper.Map<CartViewModel>(cartItems);
            return View(cartViewModel);
        }
        
        return View();

    }
}