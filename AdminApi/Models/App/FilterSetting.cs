using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class FilterSetting
    {
        public int FilterSettingId { get; set; }
        public int FilterId { get; set; }
        public int FilterValueId { get; set; }
        public int CategoryId { get; set; }
        public int Order { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
