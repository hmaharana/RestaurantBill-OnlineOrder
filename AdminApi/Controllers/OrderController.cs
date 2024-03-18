using AdminApi.Models.App.Item;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using AdminApi.Models.App.Order;
using AdminApi.DTO.App.OrderDTO;
using System.Linq;
using AdminApi.Models.Helper;
using System;
using AdminApi.DTO.App.ItemDTO;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Order> _orderRepo;
        private readonly ISqlRepository<OrderItem> _orderItemRepo;
        public OrderController(IConfiguration config,
                               AppDbContext context,
                              ISqlRepository<Order> orderRepo,
                               IConfiguration configuration, ISqlRepository<OrderItem> orderItemRepo)
        {
            _config = config;
            _context = context;
            _orderRepo = orderRepo;
            _orderItemRepo = orderItemRepo;

        }
        [HttpPost]
        public IActionResult CreateOrder(OrderDTO orderDTO)
        {
            try
            {
                Order order = new Order();
                order.VendorId = orderDTO.VendorId;
                order.LocationId = orderDTO.LocationId;
                order.PaymentMethodId = orderDTO.PaymentMethodId;
                order.OrderStatus = orderDTO.OrderStatus;
                order.CustomerName = orderDTO.CustomerName;
                order.CustomerEmail = orderDTO.CustomerEmail;
                order.CustomerMob = orderDTO.CustomerMob;
                order.TotalDiscount = orderDTO.TotalDiscount;
                order.TotalAmount = orderDTO.TotalAmount;
                order.ServiceCharges = orderDTO.ServiceCharges;
                order.OrderNote = orderDTO.OrderNote;
                order.CreatedBy = orderDTO.CreatedBy;
                order.CreatedOn = System.DateTime.Now;
                var obj = _orderRepo.Insert(order);
                for(int i = 0; i < orderDTO.OrderItemDTOs.Count; i++)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.OrderId = obj.OrderId;
                    orderItem.ItemId = orderDTO.OrderItemDTOs[i].ItemId;
                    orderItem.Quantity = orderDTO.OrderItemDTOs[i].Quantity;
                    orderItem.CreatedBy = orderDTO.CreatedBy;
                    orderItem.CreatedOn = System.DateTime.Now;
                    var orderItemObj = _orderItemRepo.Insert(orderItem);
                }
                return Ok(orderDTO);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
        [HttpGet]
        public IActionResult AllOrderList()
        {
            try
            {
                var list = (from u in _context.Orders
                            join a in _context.Vendors on u.VendorId equals a.VendorId
                            join b in _context.Locations on u.LocationId equals b.LocationId
                            join c in _context.PaymentMethods on u.PaymentMethodId equals c.PaymentMethodId
                            select new
                            {
                               
                                a.VendorName,
                                b.LocationName,
                                c.PaymentMethodName,
                                u.CreatedOn,
                                u.IsDeleted,
                                u.VendorId,
                                u.LocationId,
                                u.PaymentMethodId,
                                u.OrderStatus,
                                u.CustomerName,
                                u.CustomerMob,
                                u.CustomerEmail,
                                u.CustomerAddress,
                                u.TotalAmount,
                                u.TotalDiscount,
                                u.ServiceCharges,
                                u.OrderNote,
                                OrderItems = _context.OrderItems
                                                    .Where(x => x.OrderId == u.OrderId)
                                                    .Select(x => new OrderItemDTO
                                                    {
                                                        OrderId = x.OrderId,
                                                        ItemId = x.ItemId,
                                                        Quantity = x.Quantity,
                                                        CreatedBy = x.CreatedBy
                                                    }).ToList(),
                            }).Where(x => x.IsDeleted == false).Distinct().ToList();

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{OrderId}")]
        public ActionResult GetSingleOrder(int OrderId)
        {
            try
            {
                var list = (from u in _context.Orders
                            join a in _context.Vendors on u.VendorId equals a.VendorId
                            join b in _context.Locations on u.LocationId equals b.LocationId
                            join c in _context.PaymentMethods on u.PaymentMethodId equals c.PaymentMethodId
                           
                            select new
                            {
                                a.VendorName,
                                b.LocationName,
                                c.PaymentMethodName,
                                u.CreatedOn,
                                u.IsDeleted,
                                u.VendorId,
                                u.LocationId,
                                u.PaymentMethodId,
                                u.OrderStatus,
                                u.CustomerName,
                                u.CustomerMob,
                                u.CustomerEmail,
                                u.CustomerAddress,
                                u.TotalAmount,
                                u.TotalDiscount,
                                u.ServiceCharges,
                                u.OrderNote,
                                OrderItems = _context.OrderItems
                                                    .Where(x => x.OrderId == u.OrderId)
                                                    .Select(x => new OrderItemDTO
                                                    {
                                                        OrderId = x.OrderId,
                                                        ItemId = x.ItemId,
                                                        Quantity = x.Quantity,
                                                        CreatedBy = x.CreatedBy
                                                    }).ToList(),
                            }).Where(x => x.IsDeleted == false).Distinct().ToList();

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateOrder(UpdateOrderDTO updateOrderDTO)
        {
            try
            {
                var order = _context.Orders.SingleOrDefault(x => x.OrderId == updateOrderDTO.OrderId);
                if(order != null)
                {
                    order.VendorId = updateOrderDTO.VendorId;
                    order.LocationId = updateOrderDTO.LocationId;
                    order.PaymentMethodId = updateOrderDTO.PaymentMethodId;
                    order.OrderStatus = updateOrderDTO.OrderStatus;
                    order.CustomerName = updateOrderDTO.CustomerName;
                    order.CustomerMob = updateOrderDTO.CustomerMob;
                    order.CustomerEmail = updateOrderDTO.CustomerEmail;
                    order.CustomerAddress = updateOrderDTO.CustomerAddress;
                    order.TotalAmount = updateOrderDTO.TotalAmount;
                    order.TotalDiscount = updateOrderDTO.TotalDiscount;
                    order.ServiceCharges = updateOrderDTO.ServiceCharges;
                    order.OrderNote = updateOrderDTO.OrderNote;
                    order.UpdatedBy = updateOrderDTO.CreatedBy;
                    order.UpdatedOn = System.DateTime.Now;
                    for (int i = 0; i < updateOrderDTO.UpdateOrderItemDTOs.Count; i++)
                    {
                        OrderItem orderItem = new OrderItem();
                        orderItem.OrderId = updateOrderDTO.UpdateOrderItemDTOs[i].OrderId;
                        orderItem.ItemId = updateOrderDTO.UpdateOrderItemDTOs[i].ItemId;
                        orderItem.Quantity = updateOrderDTO.UpdateOrderItemDTOs[i].Quantity;
                        orderItem.CreatedBy = updateOrderDTO.CreatedBy;
                        orderItem.UpdatedOn = DateTime.Now;
                       
                    }
                    _context.SaveChanges();
                    return Ok(updateOrderDTO);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{OrderId}/{DeletedBy}")]
        public ActionResult DeleteOrder(int OrderId, int DeletedBy)
        {
            try
            {
                var order = _context.Orders.SingleOrDefault(opt => opt.OrderId == OrderId);
                order.IsDeleted = true;
                order.UpdatedBy = DeletedBy;
                order.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(order);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}

    

