using System;

namespace AdminApi.Models.App.Supplier
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set;}
        public string MobileNo { get; set;}
        public string SupplierEmail { get; set;}
        public int GSTId { get; set;}
        public string PayTerm { get; set;}
        public string SupplierAddress { get; set;}
        public Double TotalAmount { get; set;}
        public int VendorId { get; set;}
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
