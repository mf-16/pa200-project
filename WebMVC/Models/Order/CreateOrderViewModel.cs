using System.ComponentModel.DataAnnotations;
using WebMVC.Models.Address;

namespace WebMVC.Models.Order;

public class CreateOrderViewModel
{
    [Required]
    [StringLength(100, ErrorMessage = "Customer name cannot exceed 100 characters.")]
    public string CustomerName { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    [StringLength(255, ErrorMessage = "Customer email cannot exceed 255 characters.")]
    public string CustomerEmail { get; set; }

    public CreateAddressViewModel ShippingAddress { get; set; }

    public CreateAddressViewModel BillingAddress { get; set; }
}
