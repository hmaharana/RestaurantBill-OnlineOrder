using System;

namespace AdminApi.DTO.App.AddToCartDTO
{
    public class AddTOCartDTO
    {
        public int VendorId { get; set; }
        public int ItemId { get; set; }
        public Int64 Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateAddToCartDTO
    {
        public int AddToCartId { get; set; }
        public int VendorId { get; set; }
        public int ItemId { get; set; }
        public Int64 Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public int CreatedBy { get; set; }
    }
}
