using System.Collections.Generic;

namespace AdminApi.DTO.App.Stock
{
    public class StockDTO
    {
        public int LocationId { get; set; }
        public int SupplierId { get; set; }
       // public int ItemId { get; set; }

        public List<int> ItemId { get; set; }
        public string Status { get; set; }
        public double ShippingCharges { get; set; }
        public double TotalAmount { get; set; }
        public string AdditionalNotes { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateStockDTO
    {
        public int StockId { get; set; }
        public int LocationId { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public string Status { get; set; }
        public double ShippingCharges { get; set; }
        public double TotalAmount { get; set; }
        public string AdditionalNotes { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
