using System.Collections.Generic;

namespace AdminApi.DTO.App.OrderDTO
{
    public class OrderDTO
    {
        public int VendorId { get; set; }
        public int LocationId { get; set; }
        public int PaymentMethodId { get; set; }
        public string OrderStatus { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMob { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public double TotalAmount { get; set; }
        public double? TotalDiscount { get; set; }
        public double? ServiceCharges { get; set; }
        public string OrderNote { get; set; }
        public int CreatedBy { get; set; }
        public List<OrderItemDTO> OrderItemDTOs { get; set; }
    }
    public class UpdateOrderDTO
    {
        public int OrderId { get; set; }
        public int VendorId { get; set; }
        public int LocationId { get; set; }
        public int PaymentMethodId { get; set; }
        public string OrderStatus { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMob { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public double TotalAmount { get; set; }
        public double? TotalDiscount { get; set; }
        public double? ServiceCharges { get; set; }
        public string OrderNote { get; set; }
        public int CreatedBy { get; set; }
        public List<UpdateOrderItemDTO> UpdateOrderItemDTOs { get; set; }
    }
    public class OrderItemDTO
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateOrderItemDTO
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public int CreatedBy { get; set; }
    }
}
