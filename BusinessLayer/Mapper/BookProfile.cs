using AutoMapper;
using BusinessLayer.DTOs.Book;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<Book, ResponseBookDto>();
        CreateMap<AddBookDto, Book>();
    }
}
