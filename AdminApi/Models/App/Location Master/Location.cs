using System;

namespace AdminApi.Models.App.Location_Master
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int VendorId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Pincode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
