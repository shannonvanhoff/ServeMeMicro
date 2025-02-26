using System.ComponentModel.DataAnnotations;

namespace MServices.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        [Required]
        public decimal Discount { get; set; }
        public int MinAmount { get; set; }
    }
}
