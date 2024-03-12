using System;

namespace AdminApi.Models.App.Stock
{
    public class Stock
    {
        public int StockId { get; set; }
        public int LocationId { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public string Status { get; set; }
        public double ShippingCharges { get; set; }
        public double TotalAmount { get; set; }
        public string AdditionalNotes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
