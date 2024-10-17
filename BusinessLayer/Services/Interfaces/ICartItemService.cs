using BusinessLayer.DTOs.Cart;

namespace BusinessLayer.Services.Interfaces;

public interface ICartItemService
{
    Task<ResponseCartItemDto> AddCartItemAsync(AddCartItemDto addCartItemDto);
    Task<ResponseCartItemDto> GetCartItemAsync(int id);
    Task DeleteCartItemAsync(int id);
    Task<ResponseCartItemDto> UpdateCartItemAsync(UpdateCartItemDto updateCartItemDto);
    Task<List<ResponseCartItemDto>> GetAllCartItemsAsync();
}
