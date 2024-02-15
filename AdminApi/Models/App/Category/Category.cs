using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App.Category
{
    public class Category 
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Alias { get; set; }
        public string Icon { get; set; }
        public int? Parent { get; set; }
        public bool IsActive { get; set; }
        public int Order { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Category> Children { get; set; }
    }
}
