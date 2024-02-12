using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class UserOtpDTO
    {
        public string otp { get; set; }
        public bool isUserExists { get; set; }
        
    }
}
