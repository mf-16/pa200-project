using BusinessLayer.DTOs.Address;

namespace BusinessLayer.DTOs.Order;

public class ResponseOrderDto
{
    public int Id { get; set; }
    public string CustomerName { get; set; }

    public string CustomerEmail { get; set; }

    public AddressDto ShippingAddress { get; set; }

    public AddressDto BillingAddress { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<ResponseOrderItemDto> OrderItems { get; set; }
}
