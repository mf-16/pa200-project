namespace DataAccessLayer.Model;

public class GiftCard : BaseEntity
{
    public string Name { get; set; }
    public decimal PriceReduction { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
    public virtual ICollection<Coupon> Coupons { get; set; }
}