using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model;

public class OrderItem : BaseEntity
{
    public int OrderId { get; set; }

    [ForeignKey("OrderId")]
    public virtual Order Order { get; set; }
    public int BookId { get; set; }

    [ForeignKey("BookId")]
    public virtual Book Book { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
