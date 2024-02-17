using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AdminApi.Models.App.Vendor
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string AadharNo { get; set; }
        public string PANNo { get; set; }
        public string Image {  get; set; }
        public string Certificate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
