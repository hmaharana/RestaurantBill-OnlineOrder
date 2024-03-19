using System.Collections.Generic;

namespace AdminApi.DTO.App.Stock
{
    public class StockItemsDTO
    {
        public int StockId { get; set; }
        public int ItemId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double SubTotal { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateStockItemsDTO
    {
        public int StockItemsId { get; set; }
        public int StockId { get; set; }
        public int ItemId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double SubTotal { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
