using AutoMapper;
using BusinessLayer.DTOs.Review;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;

namespace BusinessLayer.Services;

public class ReviewService : IReviewService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ReviewService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ResponseReviewDto> CreateReviewAsync(CreateReviewDto reviewDto)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(reviewDto.UserId);
        if (user == null)
        {
            throw new NotFoundException(nameof(User), reviewDto.UserId);
        }
        var book = await _unitOfWork.BookRepository.GetByIdAsync(reviewDto.BookId);
        if (book == null)
        {
            throw new NotFoundException(nameof(Book), reviewDto.BookId);
        }
        var review = _mapper.Map<Review>(reviewDto);
        _unitOfWork.ReviewRepository.Add(review);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ResponseReviewDto>(review);
    }

    public async Task<ResponseReviewDto> UpdateReviewAsync(int id, UpdateReviewDto reviewDto)
    {
        var review = await _unitOfWork.ReviewRepository.GetByIdAsync(id);
        if (review == null)
        {
            throw new NotFoundException(nameof(Review), id);
        }
        _mapper.Map(reviewDto, review);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ResponseReviewDto>(review);
    }

    public async Task<List<ResponseReviewDto>> GetAllReviewsAsync()
    {
        var reviews = await _unitOfWork.ReviewRepository.GetAllAsync();
        return _mapper.Map<List<ResponseReviewDto>>(reviews);
    }

    public async Task DeleteReviewAsync(int id)
    {
        var review = await _unitOfWork.ReviewRepository.GetByIdAsync(id);
        if (review == null)
        {
            throw new NotFoundException(nameof(Review), id);
        }
        _unitOfWork.ReviewRepository.Delete(review);
        await _unitOfWork.CommitAsync();
    }
}
