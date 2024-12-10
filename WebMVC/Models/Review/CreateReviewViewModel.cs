using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models.Review;

public class CreateReviewViewModel
{
    public int BookId { get; set; }

    public int UserId { get; set; }

    [Required]
    [Range(1, 5, ErrorMessage = "Stars must be between 1 and 5.")]
    public int Stars { get; set; }

    [Required]
    [MaxLength(200, ErrorMessage = "Comment cannot exceed 200 characters.")]
    public string Comment { get; set; }
}
