namespace BusinessLayer.DTOs.Order;

public class ResponseOrderDto
{
    public int Id { get; set; }
    public string CustomerName { get; set; }

    public string CustomerEmail { get; set; }

    public string ShippingAddress { get; set; }

    public string BillingAddress { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<ResponseOrderItemDto> OrderItems { get; set; }
}
