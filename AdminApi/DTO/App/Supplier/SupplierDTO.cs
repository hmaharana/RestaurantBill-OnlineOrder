using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AdminApi.DTO.App.Supplier
{
    public class SupplierDTO
    {
        public string SupplierName { get; set; }
        public string MobileNo { get; set; }
        public string SupplierEmail { get; set; }
        public int GSTId { get; set; }
        public string PayTerm { get; set; }
        public string SupplierAddress { get; set; }
        public Double TotalAmount { get; set; }
        public int VendorId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateSupplierDTO
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string MobileNo { get; set; }
        public string SupplierEmail { get; set; }
        public int GSTId { get; set; }
        public string PayTerm { get; set; }
        public string SupplierAddress { get; set; }
        public Double TotalAmount { get; set; }
        public int VendorId { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
