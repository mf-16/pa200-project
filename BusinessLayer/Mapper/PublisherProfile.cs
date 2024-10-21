using AutoMapper;
using BusinessLayer.DTOs.Publisher;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;
public class PublisherProfile : Profile
{
    public PublisherProfile()
    {
        CreateMap<AddPublisherDto, Publisher>();
        CreateMap<Publisher, ResponsePublisherDto>();
    }
}
