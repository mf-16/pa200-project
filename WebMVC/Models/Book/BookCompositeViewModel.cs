namespace WebMVC.Models.Book;

public class BookCompositeViewModel
{
    public PaginatedViewModel<BookViewModel> Pagination { get; set; }
    public BookFilterViewModel Filters { get; set; }
}
