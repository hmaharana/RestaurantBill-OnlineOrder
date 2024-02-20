using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AdminApi.DTO.App.Vendor
{
    public class VendorDTO
    {
        public string VendorName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string AadharNo { get; set; }
        public string PANNo { get; set; }
        public string Image { get; set; }
        public string Certificate { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateVendorDTO
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string AadharNo { get; set; }
        public string PANNo { get; set; }
        public string Image { get; set; }
        public string Certificate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
