using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AdminApi.Models.App
{
    public class Filter
    {
        public int FilterId { get; set; }
        public string FilterName { get; set; }
        public string Alias { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
