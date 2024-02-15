using System;

namespace AdminApi.Models.App.Location_Master
{
    public class LocationInformation
    {  

        public int LocationInformationId { get; set; } 
        public double Latitude { get; set; } 
        public double Longitude { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
