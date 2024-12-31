namespace WebMVC.Models.GiftCard;

public class CreateGiftCardViewModel
{
    public string Name { get; set; }
    public decimal PriceReduction { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
    public int NumberOfCoupons { get; set; }
}