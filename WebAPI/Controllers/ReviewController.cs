using BusinessLayer.DTOs.Review;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;


[ApiController]
[Route("/api/[controller]")]
public class ReviewController : ControllerBase
{
    private readonly IReviewService _reviewService;

    public ReviewController(IReviewService reviewService)
    {
        _reviewService = reviewService;
    }


    [HttpPost]
    public async Task<ActionResult<ResponseReviewDto>> CreateReview([FromBody] CreateReviewDto createReviewDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(await _reviewService.CreateReviewAsync(createReviewDto));
    }
    
    [HttpPut("{id}")]
    public async Task<ActionResult<ResponseReviewDto>> UpdateReview(int id, [FromBody] UpdateReviewDto updateReviewDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(await _reviewService.UpdateReviewAsync(id, updateReviewDto));
    }
    [HttpGet]
    public async Task<ActionResult<ResponseReviewDto>> GetReviews()
    {
        return Ok(await _reviewService.GetAllReviewsAsync());
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReview(int id)
    {
        await _reviewService.DeleteReviewAsync(id);
        return Ok(new { message = "Review successfully deleted" });
    }
}
