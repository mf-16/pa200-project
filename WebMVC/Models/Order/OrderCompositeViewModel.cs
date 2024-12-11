namespace WebMVC.Models.Order;

public class OrderCompositeViewModel
{
    public List<OrderViewModel> Orders { get; set; }
    public EditOrderViewModel Edit { get; set; }
}