namespace WebMVC.Models.Book;

public class BookFilterCompositeViewModel
{
    public PaginatedViewModel<BookViewModel> Pagination { get; set; }
    public BookFilterViewModel Filters { get; set; }
}
