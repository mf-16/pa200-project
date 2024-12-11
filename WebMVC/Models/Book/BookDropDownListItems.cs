using WebMVC.Models.Author;
using WebMVC.Models.Genre;
using WebMVC.Models.Publisher;

namespace WebMVC.Models.Book;

public class BookDropDownListItems
{
    public IEnumerable<AuthorViewModel> Authors { get; set; }
    public IEnumerable<PublisherViewModel> Publishers { get; set; }

    public IEnumerable<GenreViewModel> Genres { get; set; }
}
