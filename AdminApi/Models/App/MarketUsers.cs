using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class MarketUsers
    {
        public int MarketUsersId { get; set; }
       // public int SellerProfileId { get; set; }
       // public int SellerKYCId { get; set; }
       // public int BuyerKYCId { get; set; }
        //public int? SellerProductId { get; set; }
        public int UserType { get; set; }
        public string MobileNumber { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        public DateTime? LastPasswordChangeDate { get; set; }
        public int? PasswordChangedBy { get; set; }
        [Required]
        public bool IsPasswordChange { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
