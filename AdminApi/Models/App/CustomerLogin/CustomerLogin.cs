using System;

namespace AdminApi.Models.App.CustomerLogin
{
    public class CustomerLogin
    {
        public int CustomerLoginId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMobNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
