namespace DataAccessLayer.Model;

public class Order : BaseEntity
{
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public decimal TotalAmount { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public int ShippingAddressId { get; set; }
    public virtual Address ShippingAddress { get; set; }
    public int BillingAddressId { get; set; }
    public virtual Address BillingAddress { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
}
