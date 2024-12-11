using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.DTOs.Book;
using WebMVC.Models;
using WebMVC.Models.Book;

namespace WebMVC.Mapper;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<ResponseBookDto, BookViewModel>();

        CreateMap<BookViewModel, ResponseBookDto>();
        CreateMap<PaginatedDto<ResponseBookDto>, PaginatedViewModel<BookViewModel>>();
        CreateMap<BookDetailViewModel, ResponseBookDto>().ReverseMap();
        CreateMap<BookFilterDto, BookFilterViewModel>().ReverseMap();
        CreateMap<UpdateBookDto, EditBookViewModel>().ReverseMap();
        CreateMap<AddBookDto, CreateBookViewModel>().ReverseMap();
        CreateMap<BookViewModel, EditBookViewModel>().ReverseMap();
    }
}
