using System;

namespace AdminApi.Models.App.Purchase
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseStatus { get; set; }
        public double TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
