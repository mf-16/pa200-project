using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Model;

public class User : IdentityUser<int>
{
    public string Name { get; set; }
    public virtual ICollection<WishlistItem> Wishlist { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
    public virtual Cart Cart { get; set; }
}
