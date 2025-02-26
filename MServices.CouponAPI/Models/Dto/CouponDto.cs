namespace MServices.CouponAPI.Models.Dto
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public decimal Discount { get; set; }
        public int MinAmount { get; set; }
    }
}
