using AutoMapper;
using BusinessLayer.DTOs.Cart;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class CartItemProfile : Profile
{
    public CartItemProfile()
    {
        CreateMap<CreateCartItemDto, CartItem>();
        CreateMap<CartItem, ResponseCartItemDto>()
            .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book.Title))
            .ForMember(dest => dest.BookPrice, opt => opt.MapFrom(src => src.Book.Price));
        CreateMap<UpdateCartItemDto, CartItem>();
        CreateMap<CartItem, ResponseCartItemDto>()
            .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book.Title))
            .ForMember(dest => dest.BookPrice, opt => opt.MapFrom(src => src.Book.Price));
    }
}
