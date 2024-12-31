namespace WebMVC.Models.GiftCard;

public class GiftCardViewModel
{
    
    public string Name { get; set; }
    public decimal PriceReduction { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
    public List<CouponViewModel> Coupons { get; set; }
}