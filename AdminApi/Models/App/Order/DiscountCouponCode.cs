using System;

namespace AdminApi.Models.App.Order
{
    public class DiscountCouponCode
    {
        public int DiscountCouponCodeId { get; set; }
        public string CouponCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
