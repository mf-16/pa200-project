using DataAccessLayer.Enums;
using DataAccessLayer.Model;

namespace BusinessLayer.DTOs.Book;

public class ResponseBookDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public int PublisherId { get; set; }
    public decimal Price { get; set; }
    public string ImagePath { get; set; }
    public BookGenre Genre { get; set; }
    public string Description { get; set; }
    public string PublisherName { get; set; }
}
