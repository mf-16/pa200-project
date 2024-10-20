using AutoMapper;
using BusinessLayer.DTOs.Review;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class ReviewProfile : Profile
{
    public ReviewProfile()
    {
        CreateMap<CreateReviewDto, Review>();
        CreateMap<Review, ResponseReviewDto>();
        CreateMap<UpdateReviewDto, Review>();
    }
}
