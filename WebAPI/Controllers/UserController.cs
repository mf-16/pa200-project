using BusinessLayer.DTOs.User;
using BusinessLayer.DTOs.WishlistItem;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IWishlistItemService _wishlistItemService;

    public UserController(IUserService userService, IWishlistItemService wishlistItemService)
    {
        _userService = userService;
        _wishlistItemService = wishlistItemService;
    }

    [HttpPost]
    public async Task<ActionResult<ResponseUserDto>> CreateUser([FromBody] CreateUserDto user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(await _userService.CreateUserAsync(user));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ResponseUserDto>> UpdateUser(
        int id,
        [FromBody] UpdateUserDto user
    )
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(await _userService.UpdateUserAsync(id, user));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ResponseUserDto>> DeleteUser(int id)
    {
        await _userService.DeleteUserAsync(id);
        return Ok(new { message = "User successfully deleted" });
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ResponseUserDto>> GetUser(int id)
    {
        return Ok(await _userService.GetUserAsync(id));
    }

    [HttpGet("{id}/wishlist")]
    public async Task<ActionResult<ResponseUserDto>> GetWishlist(int id)
    {
        return Ok(await _wishlistItemService.GetAllWishlistItemsAsync(id));
    }

    [HttpPost("{id}/wishlist")]
    public async Task<ActionResult<ResponseUserDto>> AddBookToWishlist(
        int id,
        [FromBody] CreateWishlistItemDto wishlistItemDto
    )
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(await _wishlistItemService.CreateWishlistItemAsync(id, wishlistItemDto));
    }

    [HttpDelete("{id}/wishlist/{wishlistItemId}")]
    public async Task<IActionResult> RemoveWishlistItem(int id, int wishlistItemId)
    {
        await _wishlistItemService.DeleteWishlistItemAsync(id, wishlistItemId);
        return Ok(new { message = "Wishlist item successfully deleted" });
    }
}
