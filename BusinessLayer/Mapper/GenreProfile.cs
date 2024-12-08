using AutoMapper;
using BusinessLayer.DTOs.Genre;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class GenreProfile : Profile
{
    public GenreProfile()
    {
        CreateMap<BookGenre, GenreDto>();
    }
}
