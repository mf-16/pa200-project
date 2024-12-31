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
        var coupons = Enumerable
            .Range(0, createGiftCardDto.NumberOfCoupons)
            .Select(i => new Coupon
            {
                Code = $"{createGiftCardDto.Name}_{i}",
                GiftCardId = giftCard.Id,
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

    public async Task<ResponseCouponDto?> ApplyCouponAsync(int userId, string couponCode)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user is null)
        {
            throw new NotFoundException("User", userId);
        }

        var coupon = _unitOfWork
            .CouponRepository.GetQueryable()
            .FirstOrDefault(c => c.Code == couponCode);
        if (
            coupon == null
            || coupon.CartId != null
            || coupon.OrderId != null
            || coupon.GiftCard.ValidTo < DateTime.Now
        )
        {
            return null;
        }

        user.Cart.Coupons.Add(coupon);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ResponseCouponDto>(coupon);
    }

    public async Task<List<ResponseCouponDto>> GetAllCouponsByUserAsync(int userId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user == null)
        {
            throw new NotFoundException("User", userId);
        }
        return _mapper.Map<List<ResponseCouponDto>>(user.Cart.Coupons);
    }

    public async Task RemoveCouponAsync(int userId, int couponId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user is null)
        {
            throw new NotFoundException("User", userId);
        }

        var coupon = user.Cart.Coupons.FirstOrDefault(c => c.Id == couponId);
        if (coupon == null)
        {
            throw new NotFoundException("Coupon", couponId);
        }
        user.Cart.Coupons.Remove(coupon);
        await _unitOfWork.CommitAsync();
    }
}
