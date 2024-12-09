using AutoMapper;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Profile;

namespace WebMVC.Controllers;

public class ProfileController : Controller
{
    private readonly IWishlistItemService _wishlistItemService;
    private readonly IMapper _mapper;

    public ProfileController(IWishlistItemService wishlistItemService, IMapper mapper)
    {
        _wishlistItemService = wishlistItemService;
        _mapper = mapper;
    }
    
    
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
    public async Task<IActionResult> DeleteFromWishlist(int id)
    {
        
        var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (int.TryParse(userIdClaim, out int userId))
        {
            await _wishlistItemService.DeleteWishlistItemAsync(userId, id);
        }
        return RedirectToAction(nameof(Wishlist));
    }
    
}