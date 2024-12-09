using BusinessLayer.DTOs.Cart;

namespace BusinessLayer.Services.Interfaces;

public interface ICartItemService
{
    Task<ResponseCartItemDto> CreateCartItemAsync(CreateCartItemDto createCartItemDto);
    Task<ResponseCartItemDto> GetCartItemAsync(int id);
    Task DeleteCartItemAsync(int id);
    Task<ResponseCartItemDto> UpdateCartItemAsync(int id, UpdateCartItemDto updateCartItemDto);
    Task<List<ResponseCartItemDto>> GetAllCartItemsAsync();

    Task<List<ResponseCartItemDto>> GetAllCartItemsByUserAsync(int userId);
}
