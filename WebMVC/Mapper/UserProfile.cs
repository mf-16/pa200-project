using AutoMapper;
using BusinessLayer.DTOs.Auth;
using WebMVC.Models;

namespace WebMVC.Mapper;

public class UserProfile : Profile
{
    
    public UserProfile()
    {
        CreateMap<RegisterViewModel, RegisterDTO>()
            .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            .ForMember(dest => dest.UserName, opt=> opt.MapFrom(src => $"{src.FirstName}_{src.LastName}"));
        CreateMap<LoginViewModel, LoginDTO>();
    }
}