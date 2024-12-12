namespace WebMVC.Models.Order;

public class OrderViewModel
{
    public int Id { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStateViewModel OrderState { get; set; }
}
