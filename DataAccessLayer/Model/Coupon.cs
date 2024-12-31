using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model;

public class Coupon : BaseEntity
{
    public string Code { get; set; }

    public int GiftCardId { get; set; }

    [ForeignKey("GiftCardId")]
    public virtual GiftCard GiftCard { get; set; }

    public int? OrderId { get; set; }

    [ForeignKey("OrderId")]
    public virtual Order? Order { get; set; }
}
