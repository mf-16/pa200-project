namespace WebMVC.Models;

public class PaginatedViewModel<T>
{
    public IEnumerable<T> Items { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}
