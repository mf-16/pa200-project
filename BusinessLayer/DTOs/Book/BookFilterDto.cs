using DataAccessLayer.Enums;
using DataAccessLayer.Model;

namespace BusinessLayer.DTOs.Book;

public class BookFilterDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public BookGenre? Genre { get; set; }
    public string? Publisher { get; set; }
}
