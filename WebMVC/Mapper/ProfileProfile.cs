using AutoMapper;
using BusinessLayer.DTOs.Cart;
using WebMVC.Models.Profile.Cart;

namespace WebMVC.Mapper;

public class ProfileProfile : Profile
{
    public ProfileProfile()
    {
        CreateMap<CartItemViewModel, ResponseCartItemDto>().ReverseMap();

        CreateMap<List<ResponseCartItemDto>, CartViewModel>()
            .ForMember(dest => dest.CartItems, opt => opt.MapFrom(src => src));

    }
    
}