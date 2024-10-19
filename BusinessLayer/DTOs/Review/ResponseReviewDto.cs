namespace BusinessLayer.DTOs.Review;

public class ResponseReviewDto
{
    public int Id { get; set; }
    public int Stars { get; set; }
    public string Comment { get; set; }
    public int UserId { get; set; }
    public int BookId { get; set; }

}