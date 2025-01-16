using AutoMapper;
using BusinessLayer.DTOs.Genre;
using WebMVC.Models.Genre;

namespace WebMVC.Mapper;

public class GenreProfile : Profile
{
    public GenreProfile()
    {
        CreateMap<GenreDto, GenreViewModel>();
    }
}
