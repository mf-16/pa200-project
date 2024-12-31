namespace BusinessLayer.DTOs.GiftCard;

public class ResponseCouponDto
{
    public string Code { get; set; }

    public int GiftCardId { get; set; }

    public int? OrderId { get; set; }
}
