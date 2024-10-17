namespace BusinessLayer.DTOs.Cart;

public class ResponseCartItemDto
{
    public string BookTitle { get; set; }
    public decimal BookPrice { get; set; }
    public int Quantity { get; set; }
}
