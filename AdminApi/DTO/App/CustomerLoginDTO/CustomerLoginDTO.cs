using System;

namespace AdminApi.DTO.App.CustomerLoginDTO
{
    public class CustomerLoginDTO
    {
        public string CustomerName { get; set; }
        public string CustomerMobNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
    }
    public class CustomerLoginUpdateDTO
    {
        public int CustomerLoginId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMobNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
