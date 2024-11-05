using AutoMapper;
using BusinessLayer.DTOs.Book;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<Book, ResponseBookDto>();
        CreateMap<UpdateBookDto, Book>();
        CreateMap<AddBookDto, Book>();
        CreateMap<Book, ResponseBookDto>()
            .ForMember(dest => dest.PublisherName, opt => opt.MapFrom(src => src.Publisher.Name));
    }
}
