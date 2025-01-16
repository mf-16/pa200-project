using BusinessLayer.DTOs.Book;

namespace WebMVC.Models.Cart;

public class CartItemViewModel
{
    public int Id { get; set; }
    public ResponseBookDto Book { get; set; }
    public int Quantity { get; set; }
}
