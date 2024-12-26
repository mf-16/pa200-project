using WebMVC.Models.Book;

namespace WebMVC.Models.Publisher;

public class PublisherViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Bio { get; set; }
    public List<BookViewModel> Books { get; set; }
}
