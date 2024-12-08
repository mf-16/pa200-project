using AutoMapper;
using BusinessLayer.DTOs.Publisher;
using DataAccessLayer.Model;
using WebMVC.Models.Publisher;

namespace WebMVC.Mapper;

public class PublisherProfile : Profile
{
    public PublisherProfile()
    {
        CreateMap<ResponsePublisherDto, PublisherViewModel>();
    }
}
