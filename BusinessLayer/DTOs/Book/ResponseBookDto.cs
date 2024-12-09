using BusinessLayer.DTOs.Author;
using BusinessLayer.DTOs.Genre;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.DTOs.Review;
using BusinessLayer.DTOs.WishlistItem;
using DataAccessLayer.Model;

namespace BusinessLayer.DTOs.Book;

public class ResponseBookDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public ResponseAuthorDto Author { get; set; }
    public ResponsePublisherDto Publisher { get; set; }
    public decimal Price { get; set; }
    public string ImagePath { get; set; }
    public GenreDto PrimaryGenre { get; set; }
    public IEnumerable<ResponseReviewDto> Reviews { get; set; }
    public string Description { get; set; }
    public ResponseWishlistItemDto WishlistItem{ get; set; }
}
