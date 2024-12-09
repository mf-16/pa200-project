using AutoMapper;
using BusinessLayer.DTOs.Cart;
using WebMVC.Models.Cart;

namespace WebMVC.Mapper;

public class CartProfile : Profile
{
    public CartProfile()
    {
        CreateMap<CreateCartItemViewModel, CreateCartItemDto>();
        CreateMap<UpdateCartItemViewModel, UpdateCartItemDto>();
    }
}
