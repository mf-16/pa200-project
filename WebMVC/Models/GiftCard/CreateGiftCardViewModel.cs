using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models.GiftCard;

public class CreateGiftCardViewModel
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Price reduction is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price reduction must be greater than 0.")]
    public decimal PriceReduction { get; set; }

    [Required(ErrorMessage = "Valid From date is required.")]
    [DataType(DataType.Date)]
    [Display(Name = "Valid From")]
    public DateTime ValidFrom { get; set; }

    [Required(ErrorMessage = "Valid To date is required.")]
    [DataType(DataType.Date)]
    [Display(Name = "Valid To")]
    public DateTime ValidTo { get; set; }

    [Required(ErrorMessage = "Number of coupons is required.")]
    [Range(1, 1000, ErrorMessage = "Number of coupons must be between 1 and 1000.")]
    public int NumberOfCoupons { get; set; }
}
