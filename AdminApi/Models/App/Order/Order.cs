using System;

namespace AdminApi.Models.App.Order
{
    public class Order
    {
        public int OrderId { get; set; }
        public int VendorId { get; set; }
        public int LocationId { get; set; }
        public int PaymentMethodId { get; set; }
        public string OrderStatus { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMob { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public double TotalAmount { get; set; }
        public double? TotalDiscount { get; set; }
        public double? ServiceCharges { get; set; }
        public string OrderNote { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
