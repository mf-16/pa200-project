using AutoMapper;
using BusinessLayer.DTOs.Author;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Author, ResponseAuthorDto>().ReverseMap();
        CreateMap<UpdateAuthorDto, Author>();
        CreateMap<AddAuthorDto, Author>();
    }
}
