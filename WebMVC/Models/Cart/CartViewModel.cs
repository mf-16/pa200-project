namespace WebMVC.Models.Cart;

public class CartViewModel
{
    public ICollection<CartItemViewModel> CartItems { get; set; }
}
