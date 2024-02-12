using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class MarketUserInfo
    {
        public int MarketUserId { get; set; }
        public int SellerProfileId { get; set; }
        public int SellerKYCId { get; set; }
        public int BuyerKYCId { get; set; }
        public int UserType { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public int? LastUpdatedBy { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public string ShopImage { get; set; }
        public string CompanyOwnerName { get; set; }
        public string CompanyEmailId { get; set; }
        public string GSTINNo { get; set; }
        public string BusinessPANcardNo { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string ALTMobileNumber { get; set; }
        public string BusinessType { get; set; }
        public string ShopName { get; set; }
        public string ShopOwnerName { get; set; }
        public int? CreatedBy { get; set; }

    }
}
