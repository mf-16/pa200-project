using WebMVC.Models.Book;

namespace WebMVC.Models.Profile;

public class WishlistItemViewModel
{
    public int Id { get; set; }
    public BookViewModel Book { get; set; }
    public int UserId { get; set; }
}
