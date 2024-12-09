using BusinessLayer.DTOs.WishlistItem;

namespace BusinessLayer.Services.Interfaces;

public interface IWishlistItemService
{
    Task<ResponseWishlistItemDto> CreateWishlistItemAsync(int userId, CreateWishlistItemDto dto);
    Task<List<ResponseWishlistItemDto>> GetAllWishlistItemsAsync(int userId);
    Task DeleteWishlistItemAsync(int userId, int wishlistItemId);
    Task<bool> IsWishlistedAsync(int userId, int wishlistItemId);
}
