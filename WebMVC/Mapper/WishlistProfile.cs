using AutoMapper;
using BusinessLayer.DTOs.WishlistItem;
using WebMVC.Models.Profile;

namespace WebMVC.Mapper;

public class WishlistProfile : Profile
{
    public WishlistProfile()
    {
        CreateMap<ResponseWishlistItemDto, WishlistItemViewModel>();
    }
}
