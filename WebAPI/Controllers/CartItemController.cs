using BusinessLayer.DTOs.Cart;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CartItemController : ControllerBase
{
    private readonly ICartItemService _cartItemService;

    public CartItemController(ICartItemService cartItemService)
    {
        _cartItemService = cartItemService;
    }

    [HttpPost]
    public async Task<ActionResult<ResponseCartItemDto>> AddCartItem(
        [FromBody] AddCartItemDto addCartItemDto
    )
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var response = await _cartItemService.AddCartItemAsync(addCartItemDto);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<ResponseCartItemDto>> UpdateCartItem(
        [FromBody] UpdateCartItemDto updateCartItemDto
    )
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var response = await _cartItemService.UpdateCartItemAsync(updateCartItemDto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<ResponseCartItemDto>> GetCartItems()
    {
        return Ok(await _cartItemService.GetAllCartItemsAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ResponseCartItemDto>> GetCartItemById(int id)
    {
        return Ok(await _cartItemService.GetCartItemAsync(id));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ResponseCartItemDto>> DeleteCartItem(int id)
    {
        await _cartItemService.DeleteCartItemAsync(id);
        return Ok(new { message = "Cart Item successfully deleted" });
    }
}
