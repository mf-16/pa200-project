namespace WebMVC.Models.Book;

public class BookFilterViewModel
{
    public string? Name { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public int? GenreId { get; set; }
    public string? Publisher { get; set; }
}
