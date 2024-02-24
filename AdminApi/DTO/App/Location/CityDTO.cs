using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App.Location
{
    public class CityDTO
    {
        public string CityName { get; set; }
        public int VendorId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateCityDTO
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int VendorId { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
