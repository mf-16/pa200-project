using AutoMapper;
using BusinessLayer.DTOs.Author;
using WebMVC.Models.Author;

namespace WebMVC.Mapper;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<ResponseAuthorDto, AuthorViewModel>();
    }
}
