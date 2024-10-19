using AutoMapper;
using BusinessLayer.DTOs.WishlistItem;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class WishlistItemProfile : Profile
{
    public WishlistItemProfile()
    {
        CreateMap<CreateWishlistItemDto, WishlistItem>();
        CreateMap<WishlistItem, ResponseWishlistItemDto>();
    }
}