using WebMVC.Models.Address;

namespace WebMVC.Models.Order;

public class OrderDetailViewModel
{
    public int Id { get; set; }
    public string CustomerName { get; set; }

    public string CustomerEmail { get; set; }

    public AddressViewModel ShippingAddress { get; set; }

    public AddressViewModel BillingAddress { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<OrderItemViewModel> OrderItems { get; set; }

    public OrderStateViewModel OrderState { get; set; }
}
