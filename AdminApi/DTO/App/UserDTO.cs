using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class UserUpdateDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EmialId { get; set; }
        public string Photo { get; set; }
    }
}
