using System;

namespace AdminApi.Models.App.Order
{
    public class POSOrderItem
    {
        public Int64 POSOrderItemId { get; set; }
        public int VendorId { get; set; }
        public int ItemId { get; set;}
        public Int64 Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
