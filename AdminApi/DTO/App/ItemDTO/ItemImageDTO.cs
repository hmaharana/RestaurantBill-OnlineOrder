using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AdminApi.DTO.App.ItemDTO
{
    public class ItemImageDTO
    {
        public int ItemId { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateItemImageDTO
    {
        public int ItemImageId { get; set; }
        public int ItemId { get; set; }
        public string Image { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
