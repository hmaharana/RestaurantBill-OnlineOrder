using System;

namespace AdminApi.DTO.App.Purchase
{
    public class PurchaseDTO
    {
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseStatus { get; set; }
        public double TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdatePurchaseDTO
    {
        public int PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseStatus { get; set; }
        public double TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
