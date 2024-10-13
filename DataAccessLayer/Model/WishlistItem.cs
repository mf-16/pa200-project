using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model;

public class WishlistItem: BaseEntity
{
    
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual User User { get; set; }
    
    public int BookId { get; set; }
    [ForeignKey("BookId")]
    public virtual Book Book { get; set; }
}