using System;

namespace AdminApi.Models.App.Location_Master
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Code { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
