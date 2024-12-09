using AutoMapper;
using BusinessLayer.DTOs.WishlistItem;
using WebMVC.Models.Wishlist;

namespace WebMVC.Mapper;

public class WishlistProfile : Profile
{
    public WishlistProfile()
    {
        CreateMap<CreateWishlistItemViewModel, CreateWishlistItemDto>().ReverseMap();
        CreateMap<ResponseWishlistItemDto, WishlistItemViewModel>().ReverseMap();
    }
}
