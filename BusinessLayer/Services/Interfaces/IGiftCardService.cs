using BusinessLayer.DTOs.GiftCard;

namespace BusinessLayer.Services.Interfaces;

public interface IGiftCardService
{
    public Task<ResponseGiftCardDto> CreateGiftCardAsync(CreateGiftCardDto createGiftCardDto);
    public Task<ResponseGiftCardDto> GetGiftCardAsync(int id);
    public Task<List<ResponseGiftCardDto>> GetAllGiftCardsAsync();
}
