using WebMVC.Models.Book;

namespace WebMVC.Models.Cart;

public class CreateCartItemViewModel
{
    public int BookId { get; set; }
    public int Quantity { get; set; }
}
