using AutoMapper;
using BusinessLayer.DTOs.Cart;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class CartItemProfile : Profile
{
    public CartItemProfile()
    {
        CreateMap<CreateCartItemDto, CartItem>();
        CreateMap<CartItem, ResponseCartItemDto>();
        CreateMap<UpdateCartItemDto, CartItem>();
    }
}
