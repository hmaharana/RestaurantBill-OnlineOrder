namespace AdminApi.DTO.App.Location
{
    public class LocationDTO
    {
        public string LocationName { get; set; }
        public int VendorId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Pincode { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateLocationDTO
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int VendorId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Pincode { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
