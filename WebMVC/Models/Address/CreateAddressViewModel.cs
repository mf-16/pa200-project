using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models.Address;

public class CreateAddressViewModel
{
    [Required]
    [StringLength(100, ErrorMessage = "Street address cannot exceed 100 characters.")]
    public string Street { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "City name cannot exceed 50 characters.")]
    public string City { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "State name cannot exceed 50 characters.")]
    public string State { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Zip code cannot exceed 20 characters.")]
    public string ZipCode { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Country name cannot exceed 50 characters.")]
    public string Country { get; set; }
}
