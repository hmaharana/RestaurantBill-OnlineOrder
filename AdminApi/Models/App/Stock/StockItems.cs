using System;

namespace AdminApi.Models.App.Stock
{
    public class StockItems
    {
        public int StockItemsId { get; set; }
        public int StockId { get; set; }
        public string Product {  get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double SubTotal { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
