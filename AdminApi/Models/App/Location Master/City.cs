using System;

namespace AdminApi.Models.App.Location_Master
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int VendorId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
