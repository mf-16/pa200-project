using AutoMapper;
using BusinessLayer.DTOs.GiftCard;
using WebMVC.Models.GiftCard;

namespace WebMVC.Mapper;

public class GiftCardProfile : Profile
{
    public GiftCardProfile()
    {
        CreateMap<ResponseGiftCardDto, GiftCardViewModel>();
        CreateMap<CreateGiftCardViewModel, CreateGiftCardDto>()
            // Convert ValidFrom and ValidTo to UTC to ensure consistent storage in the database,
            // as PostgreSQL expects timestamps to be in UTC (timestamp with time zone).
            .ForMember(
                dest => dest.ValidFrom,
                opt => opt.MapFrom(src => src.ValidFrom.ToUniversalTime())
            )
            .ForMember(
                dest => dest.ValidTo,
                opt => opt.MapFrom(src => src.ValidTo.ToUniversalTime())
            );
        CreateMap<ResponseCouponDto, CouponViewModel>();
    }
}
