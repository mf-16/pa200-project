using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model;

public class CartItem : BaseEntity
{
    public int CartId { get; set; }

    [ForeignKey("CartId")]
    public virtual Cart Cart { get; set; }
    public int BookId { get; set; }

    [ForeignKey("BookId")]
    public virtual Book Book { get; set; }
    public int Quantity { get; set; }
}
