using DataAccessLayer.Model;

namespace BusinessLayer.DTOs.Book;

public class BookFilterDto
{
    public string? Name { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public int? GenreId { get; set; }
    public int? PublisherId { get; set; }
    public int? AuthorId { get; set; }
}
