using System.ComponentModel.DataAnnotations;
using BusinessLayer.DTOs.Address;

namespace BusinessLayer.DTOs.Order;

public class CreateOrderDto
{
    [Required]
    [StringLength(100, ErrorMessage = "Customer name cannot exceed 100 characters.")]
    public string CustomerName { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    [StringLength(255, ErrorMessage = "Customer email cannot exceed 255 characters.")]
    public string CustomerEmail { get; set; }

    [Required]
    public AddressDto ShippingAddress { get; set; }

    [Required]
    public AddressDto BillingAddress { get; set; }
}
