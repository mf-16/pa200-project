using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Review;

public class UpdateReviewDto
{
    
    [Range(1, 5, ErrorMessage = "Stars must be between 1 and 5.")]
    public int? Stars { get; set; }
    
    [MaxLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
    public string? Comment { get; set; }
    
    
}