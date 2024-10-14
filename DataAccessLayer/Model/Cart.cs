using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model;

public class Cart : BaseEntity
{
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
    public virtual ICollection<CartItem> CartItems { get; set; }
}
