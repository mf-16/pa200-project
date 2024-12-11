using WebMVC.Models.Author;
using WebMVC.Models.Genre;
using WebMVC.Models.Publisher;

namespace WebMVC.Models.Book;

public class BookViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public AuthorViewModel Author { get; set; }
    public PublisherViewModel Publisher { get; set; }
    public decimal Price { get; set; }
    public string ImagePath { get; set; }
    
    public string Description { get; set; }
    public GenreViewModel PrimaryGenre { get; set; }
}
