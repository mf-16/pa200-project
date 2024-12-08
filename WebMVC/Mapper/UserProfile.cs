using AutoMapper;
using BusinessLayer.DTOs.Auth;
using BusinessLayer.DTOs.User;
using WebMVC.Models;
using WebMVC.Models.User;
using WebMVC.Models.Account;

namespace WebMVC.Mapper;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterViewModel, RegisterDTO>()
            .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}")
            )
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => $"{src.Email}"));
        CreateMap<LoginViewModel, LoginDTO>();
        CreateMap<ResponseUserDto, UserViewModel>();
    }
}
