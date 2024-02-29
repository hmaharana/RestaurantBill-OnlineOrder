using AdminApi.Models.App.Item;
using System;
using System.Collections.Generic;

namespace AdminApi.DTO.App.ItemDTO
{
    public class ItemDTO
    {
        public string ItemName { get; set; }
        public int VendorId { get; set; }
        public int CategoryId { get; set; }
        public double SalePrice { get; set; }
        public double MRP { get; set; }
        public double? DiscountAmount { get; set; }
        public string? ColorCode { get; set; }
        public bool? Status { get; set; }
        public double? GSTAmount { get; set; }
        public int? GSTId { get; set; }
        public bool? TaxType { get; set; } // In , Ex
        public string HNSCode { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<ItemsDTO> itemsDTOs { get; set; }
    }
    public class ItemUpdateDTO
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int VendorId { get; set; }
        public int CategoryId { get; set; }
        public double SalePrice { get; set; }
        public double MRP { get; set; }
        public double? DiscountAmount { get; set; }
        public string? ColorCode { get; set; }
        public bool? Status { get; set; }
        public double? GSTAmount { get; set; }
        public int? GSTId { get; set; }
        public bool? TaxType { get; set; } // In , Ex
        public string HNSCode { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }

    public class ItemsDTO
    {
        //public int ItemId { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
