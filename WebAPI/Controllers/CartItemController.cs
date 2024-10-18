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
        [FromBody] CreateCartItemDto createCartItemDto
    )
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var response = await _cartItemService.CreateCartItemAsync(createCartItemDto);
        return Ok(response);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ResponseCartItemDto>> UpdateCartItem(int id, 
        [FromBody] UpdateCartItemDto updateCartItemDto
    )
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var response = await _cartItemService.UpdateCartItemAsync(id, updateCartItemDto);
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
