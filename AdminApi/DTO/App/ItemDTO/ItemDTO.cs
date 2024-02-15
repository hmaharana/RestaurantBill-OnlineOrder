﻿namespace AdminApi.DTO.App.ItemDTO
{
    public class ItemDTO
    {
        public string ItemName { get; set; }
        public int CategoryId { get; set; }
        public double SalePrice { get; set; }
        public double MRP { get; set; }
        public double DiscountAmount { get; set; }
        public string TaxType { get; set; } // In , Ex
        public double TaxPercentage { get; set; }
        public string ItemImage { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
    }
    public class ItemUpdateDTO
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int CategoryId { get; set; }
        public double SalePrice { get; set; }
        public double MRP { get; set; }
        public double DiscountAmount { get; set; }
        public double Tax { get; set; }
        public bool TaxApplicable { get; set; }
        public string ItemImage { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
    }
}