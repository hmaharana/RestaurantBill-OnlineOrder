using System;

namespace AdminApi.Models.App.Item
{
    public class ItemImage
    {
        public int ItemImageId { get; set; }
        public int ItemId { get; set; }
        public string MainImage { get; set; }
        //public string Image { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
