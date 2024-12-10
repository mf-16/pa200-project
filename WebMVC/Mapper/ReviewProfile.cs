using AutoMapper;
using BusinessLayer.DTOs.Review;
using WebMVC.Models.Review;

namespace WebMVC.Mapper;

public class ReviewProfile : Profile
{
    public ReviewProfile()
    {
        CreateMap<ResponseReviewDto, ReviewViewModel>().ReverseMap();
        CreateMap<CreateReviewViewModel, CreateReviewDto>();
    }
}
