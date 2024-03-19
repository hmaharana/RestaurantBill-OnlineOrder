namespace AdminApi.ViewModels.Order
{
    public class OrderView
    {
        public int OrderId { get; set; }
        public int VendorName { get; set; }
        public int LocationName { get; set; }
        public int PaymentMethodName { get; set; }
        public int ItemName { get; set; }
        public string OrderStatus { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMob { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public double TotalAmount { get; set; }
        public double Quantity { get; set; }
        public double? TotalDiscount { get; set; }
        public double? ServiceCharges { get; set; }
        public int CreatedBy { get; set; }
    }
}
