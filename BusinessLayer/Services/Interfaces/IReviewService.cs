using BusinessLayer.DTOs.Review;

namespace BusinessLayer.Services.Interfaces;

public interface IReviewService
{
    Task<ResponseReviewDto> CreateReviewAsync(CreateReviewDto reviewDto);
    Task<ResponseReviewDto> UpdateReviewAsync(int id, UpdateReviewDto reviewDto);
    Task<List<ResponseReviewDto>> GetAllReviewsAsync();
    Task DeleteReviewAsync(int reviewId);
}
