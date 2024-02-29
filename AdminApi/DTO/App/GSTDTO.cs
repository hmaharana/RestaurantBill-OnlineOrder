namespace AdminApi.DTO.App
{
    public class GSTDTO
    {
        public string GSTName { get; set; }
        public double Percentage { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateGSTDTO
    {
        public int GSTId { get; set; }
        public string GSTName { get; set; }
        public double Percentage { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
