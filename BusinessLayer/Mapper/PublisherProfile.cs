using AutoMapper;
using BusinessLayer.DTOs.Publisher;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class PublisherProfile : Profile
{
    public PublisherProfile()
    {
        CreateMap<Publisher, ResponsePublisherDto>();
        CreateMap<AddPublisherDto, Publisher>();
    }
}
