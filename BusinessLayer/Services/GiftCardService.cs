using AutoMapper;
using BusinessLayer.DTOs.GiftCard;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;

namespace BusinessLayer.Services;

public class GiftCardService : IGiftCardService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GiftCardService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<ResponseGiftCardDto> CreateGiftCardAsync(CreateGiftCardDto createGiftCardDto)
    {
        var giftCard = _mapper.Map<GiftCard>(createGiftCardDto);
        var coupons = Enumerable.Range(0, createGiftCardDto.NumberOfCoupons)
            .Select(i => new Coupon
            {
                Code = $"{createGiftCardDto.Name}_{i}",
                GiftCardId = giftCard.Id
            })
            .ToList();
        giftCard.Coupons = coupons;
        _unitOfWork.GiftCardRepository.Add(giftCard);
        var response = _mapper.Map<ResponseGiftCardDto>(giftCard);
        await _unitOfWork.CommitAsync();
        return response;
    }

    public async Task<ResponseGiftCardDto> GetGiftCardAsync(int id)
    {
        var giftCard = await _unitOfWork.GiftCardRepository.GetByIdAsync(id);
        if (giftCard == null)
        {
            throw new NotFoundException("GiftCard", id);
        }
        var response = _mapper.Map<ResponseGiftCardDto>(giftCard);
        return response;
    }

    public async Task<List<ResponseGiftCardDto>> GetAllGiftCardsAsync()
    {
        var giftCards = await _unitOfWork.GiftCardRepository.GetAllAsync();
        var response = _mapper.Map<List<ResponseGiftCardDto>>(giftCards);
        return response;
    }
}