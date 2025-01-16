using AutoMapper;
using BusinessLayer.DTOs.Author;
using DataAccessLayer.Model;
using WebMVC.Models.Author;
using WebMVC.Models.Book;

namespace WebMVC.Mapper;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<Author, AuthorViewModel>()
            .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books));
        CreateMap<CreateAuthorViewModel, AddAuthorDto>();
        CreateMap<UpdateAuthorViewModel, UpdateAuthorDto>();
        CreateMap<Author, UpdateAuthorViewModel>();
        CreateMap<ResponseAuthorDto, AuthorViewModel>()
            .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books));
        CreateMap<ResponseAuthorDto, UpdateAuthorViewModel>();
        CreateMap<Book, BookViewModel>();
    }
}
