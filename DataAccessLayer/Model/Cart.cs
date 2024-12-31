using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model;

public class Cart : BaseEntity
{
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }
    public virtual ICollection<Coupon> Coupons { get; set; }
}
