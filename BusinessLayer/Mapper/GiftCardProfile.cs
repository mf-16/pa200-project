using AutoMapper;
using BusinessLayer.DTOs.GiftCard;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class GiftCardProfile : Profile
{
    public GiftCardProfile()
    {
        CreateMap<CreateGiftCardDto, GiftCard>()
            .ForMember(dest => dest.Coupons, opt => opt.Ignore());
        CreateMap<GiftCard, ResponseGiftCardDto>();
        CreateMap<Coupon, ResponseCouponDto>()
            .ForMember(dest => dest.Amount, src => src.MapFrom(c => c.GiftCard.PriceReduction));
    }
}
