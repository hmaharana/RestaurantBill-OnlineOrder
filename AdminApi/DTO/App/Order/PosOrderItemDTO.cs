using System;

namespace AdminApi.DTO.App.Order
{
    public class PosOrderItemDTO
    {
        public int VendorId { get; set; }
        public int ItemId { get; set; }
        public Int64 Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateOrderItemDTO
    {
        public Int64 POSOrderItemId { get; set; }
        public int VendorId { get; set; }
        public int ItemId { get; set; }
        public Int64 Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
