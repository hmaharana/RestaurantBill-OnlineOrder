using System;

namespace AdminApi.Models.App.Order
{
    public class CheckOut
    {
        public int CheckOutId { get; set; }
        public int ItemId { get; set; }
        public Int64 Quantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
