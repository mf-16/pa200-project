namespace BusinessLayer.DTOs.Order;

public class ResponseOrderItemDto
{
    public int Id { get; set; }
    public decimal BookPrice { get; set; }
    public string BookTitle { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
