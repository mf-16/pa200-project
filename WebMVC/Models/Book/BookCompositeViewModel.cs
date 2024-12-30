using WebMVC.Models.Author;
using WebMVC.Models.Genre;
using WebMVC.Models.Publisher;

namespace WebMVC.Models.Book;

public class BookCompositeViewModel
{
    public PaginatedViewModel<BookViewModel> Pagination { get; set; }
    public BookFilterViewModel Filters { get; set; }
    public IEnumerable<GenreViewModel> Genres { get; set; }

    public IEnumerable<AuthorViewModel> Authors { get; set; }
    public IEnumerable<PublisherViewModel> Publishers { get; set; }
}
