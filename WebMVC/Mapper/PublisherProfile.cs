using AutoMapper;
using BusinessLayer.DTOs.Publisher;
using DataAccessLayer.Model;
using WebMVC.Models.Book;
using WebMVC.Models.Publisher;

namespace WebMVC.Mapper;

public class PublisherProfile : Profile
{
    public PublisherProfile()
    {
        CreateMap<Publisher, PublisherViewModel>()
            .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books));
        CreateMap<CreatePublisherViewModel, AddPublisherDto>();
        CreateMap<UpdatePublisherViewModel, UpdatePublisherDto>();
        CreateMap<Publisher, UpdatePublisherViewModel>();
        CreateMap<ResponsePublisherDto, PublisherViewModel>()
            .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books));
        CreateMap<ResponsePublisherDto, UpdatePublisherViewModel>();
        CreateMap<Book, BookViewModel>();
    }
}
