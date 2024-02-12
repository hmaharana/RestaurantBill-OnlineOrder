using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class FilterDTO
    {
        public string FilterName { get; set; }
        public string Alias { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateFilterDTO
    {
        public int FilterId { get; set; }
        public string FilterName { get; set; }
        public string Alias { get; set; }
        public int CreatedBy { get; set; }
    }
}
