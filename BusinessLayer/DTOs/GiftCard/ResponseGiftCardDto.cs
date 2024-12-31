namespace BusinessLayer.DTOs.GiftCard;

public class ResponseGiftCardDto
{
    
    public string Name { get; set; }
    public decimal PriceReduction { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
    public List<ResponseCouponDto> Coupons { get; set; }
}