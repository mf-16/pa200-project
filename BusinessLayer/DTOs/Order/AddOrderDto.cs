using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Order;

public class AddOrderDto
{
    [Required]
    [StringLength(100, ErrorMessage = "Customer name cannot exceed 100 characters.")]
    public string CustomerName { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    [StringLength(255, ErrorMessage = "Customer email cannot exceed 255 characters.")]
    public string CustomerEmail { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "Shipping address cannot exceed 500 characters.")]
    public string ShippingAddress { get; set; }

    [Required]
    [StringLength(500, ErrorMessage = "Billing address cannot exceed 500 characters.")]
    public string BillingAddress { get; set; }

    [Required]
    public int CartId { get; set; }
}
