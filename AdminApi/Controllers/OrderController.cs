using AdminApi.DTO.App.OrderDTO;
using AdminApi.Models;
using AdminApi.Models.App.Item;
using AdminApi.Models.App.Order;
using AdminApi.Models.Helper;
using AdminApi.ViewModels.Order;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

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
        private readonly ISqlRepository<Item> _itemRepo;
        public OrderController(IConfiguration config,
                               AppDbContext context,
                              ISqlRepository<Order> orderRepo,
                               IConfiguration configuration, ISqlRepository<OrderItem> orderItemRepo, ISqlRepository<Item> itemRepo)
        {
            _config = config;
            _context = context;
            _orderRepo = orderRepo;
            _orderItemRepo = orderItemRepo;
            _itemRepo = itemRepo;

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
                order.CustomerAddress = orderDTO.CustomerAddress;
                order.TotalDiscount = orderDTO.TotalDiscount;
                order.TotalAmount = orderDTO.TotalAmount;
                order.ServiceCharges = orderDTO.ServiceCharges;
                order.OrderNote = orderDTO.OrderNote;
                order.CreatedBy = orderDTO.CreatedBy;
                order.CreatedOn = DateTime.Now;
                var obj = _orderRepo.Insert(order);
                for (int i = 0; i < orderDTO.OrderItemDTOs.Count; i++)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.OrderId = obj.OrderId;
                    orderItem.ItemId = orderDTO.OrderItemDTOs[i].ItemId;
                    orderItem.Quantity = orderDTO.OrderItemDTOs[i].Quantity;
                    orderItem.CreatedBy = orderDTO.CreatedBy;
                    orderItem.CreatedOn = DateTime.Now;
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
                            join d in _context.OrderItems on u.OrderId equals d.OrderId
                            join e in _context.Items on d.ItemId equals e.ItemId
                         
                            select new
                            {
                                u.OrderId,
                                a.VendorName,
                                b.LocationName,
                                c.PaymentMethodName,
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
                                e.ItemName,
                                e.ItemId,
                                d.Quantity,
                                u.OrderNote,
                                u.IsDeleted,
                                //OrderItem = (from r in _context.OrderItems
                                //             join s in _context.Items on r.ItemId equals s.ItemId
                                //             where r.OrderId == u.OrderId
                                //             select new
                                //             {
                                //                 r.OrderId,
                                //                 s.ItemName,
                                //                 r.Quantity,
                                //             }).ToList()

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
                                u.OrderId,
                                a.VendorName,
                                b.LocationName,
                                c.PaymentMethodName,
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
                                u.CreatedOn,
                                u.IsDeleted,
                                OrderItems = _context.OrderItems
                                                    .Where(x => x.OrderId == u.OrderId)
                                                    .Select(x => new OrderItemDTO
                                                    {
                                                        OrderId = x.OrderId,
                                                        ItemId = x.ItemId,
                                                        Quantity = x.Quantity,
                                                        CreatedBy = x.CreatedBy
                                                    }).ToList(),
                            }).Where(x => x.OrderId == OrderId && x.IsDeleted == false).Distinct().ToList();

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
                if (order != null)
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
                    order.UpdatedOn = DateTime.Now;
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
                order.UpdatedOn = DateTime.Now;
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



