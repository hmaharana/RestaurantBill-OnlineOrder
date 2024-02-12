using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class FilterValueDTO
    {
        public int FilterId { get; set; }
        public string FilterValueName { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdateFilterValueDTO
    {
        public int FilterValuesId { get; set; }
        public int FilterId { get; set; }
        public string FilterValueName { get; set; }
        public int CreatedBy { get; set; }
    }
}
