using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class MarketUsersDTO
    {
        public int UserType { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public int CreatedBy { get; set; }
    }
    public class MarketUsersUpdateDTO
    {
       
        public int UserType { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateMarketUsersWebDTO
    {

        public int MarketUsersId { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
    }

}
