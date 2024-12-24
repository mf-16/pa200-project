using AutoMapper;
using BusinessLayer.DTOs.Publisher;
using DataAccessLayer.Model;
using WebMVC.Models.Publisher;

namespace WebMVC.Mapper;

public class PublisherProfile : Profile
{
    public PublisherProfile()
    {
        CreateMap<Publisher, PublisherViewModel>();
        CreateMap<CreatePublisherViewModel, AddPublisherDto>();
        CreateMap<UpdatePublisherViewModel, UpdatePublisherDto>();
        CreateMap<Publisher, UpdatePublisherViewModel>();
        CreateMap<ResponsePublisherDto, PublisherViewModel>();
        CreateMap<ResponsePublisherDto, UpdatePublisherViewModel>();
    }
}
