using AutoMapper;
using BusinessLayer.DTOs.Auth;
using BusinessLayer.DTOs.User;

using WebMVC.Models.Account;
using WebMVC.Models.User;

namespace WebMVC.Mapper;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<ResponseUserDto, UserViewModel>().ReverseMap();
        CreateMap<RegisterViewModel, RegisterDTO>()
            .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}")
            )
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => $"{src.Email}"));
        CreateMap<LoginViewModel, LoginDTO>();
    }
}
