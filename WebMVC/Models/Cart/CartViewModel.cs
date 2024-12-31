using WebMVC.Models.GiftCard;

namespace WebMVC.Models.Cart;

public class CartViewModel
{
    public ICollection<CartItemViewModel> CartItems { get; set; }
    public ICollection<CouponViewModel> Coupons { get; set; }
}
