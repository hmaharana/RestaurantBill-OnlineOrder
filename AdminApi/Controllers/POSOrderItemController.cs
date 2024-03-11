using AdminApi.DTO.App.Order;
using AdminApi.Models;
using AdminApi.Models.App.Order;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class POSOrderItemController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<POSOrderItem> _pOSOrderItemRepo;
        public POSOrderItemController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<POSOrderItem> pOSOrderItemRepo
                               )
        {
            _config = config;
            _context = context;
            _pOSOrderItemRepo = pOSOrderItemRepo;

        }
        [HttpPost]
        public IActionResult CreatePOSOrderItem(PosOrderItemDTO posOrderItemDTO)
        {
            try
            {
                var objCheck = _context.POSOrderItems.SingleOrDefault(x => x.ItemId == posOrderItemDTO.ItemId && x.IsDeleted == false);
                if (objCheck == null)
                {
                    POSOrderItem pOSOrderItem = new POSOrderItem();
                    pOSOrderItem.ItemId = posOrderItemDTO.ItemId;
                    pOSOrderItem.VendorId = posOrderItemDTO.VendorId;
                    pOSOrderItem.Quantity = posOrderItemDTO.Quantity;
                    pOSOrderItem.Price = posOrderItemDTO.Price;
                    pOSOrderItem.TotalPrice = posOrderItemDTO.TotalPrice;
                    pOSOrderItem.CreatedBy = posOrderItemDTO.CreatedBy;
                    var obj = _pOSOrderItemRepo.Insert(pOSOrderItem);
                    return Ok(obj);


                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate POSOrderItem!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }


        }
        [HttpGet]
        public ActionResult GetPOSOrderItemList()
        {
            try
            {
                var list = (from u in _context.POSOrderItems
                            join a in _context.Vendors on u.VendorId equals a.VendorId
                            join b in _context.Items on u.ItemId equals b.ItemId
                            select new
                            {
                                u.VendorId,
                                u.POSOrderItemId,
                                a.VendorName,
                                u.ItemId,
                                b.ItemName,
                                u.Quantity,
                                u.Price,
                                u.TotalPrice,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{pOSOrderItemId}")]
        public ActionResult GetSinglePOSOrderItemId(Int64 POSOrderItemId)
        {
            try
            {
                var singlepOSOrderItem = _pOSOrderItemRepo.SelectById(POSOrderItemId);

                return Ok(singlepOSOrderItem);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdatePOSOrderItem(UpdateOrderItemDTO updateOrderItemDTO)
        {
            try
            {
                var pOSOrderItem =_context.POSOrderItems.SingleOrDefault(x => x.POSOrderItemId ==  updateOrderItemDTO.POSOrderItemId);
                if(pOSOrderItem != null)
                {
                    pOSOrderItem.VendorId = updateOrderItemDTO.VendorId;
                    pOSOrderItem.ItemId = updateOrderItemDTO.ItemId;
                    pOSOrderItem.Quantity = updateOrderItemDTO.Quantity;
                    pOSOrderItem.Price = updateOrderItemDTO.Price;
                    pOSOrderItem.TotalPrice = updateOrderItemDTO.TotalPrice;
                    pOSOrderItem.UpdatedBy = updateOrderItemDTO.UpdatedBy;
                    pOSOrderItem.UpdatedOn = System.DateTime.Now;
                    _context.SaveChanges();
                    return Ok(pOSOrderItem);
                }
                else
                {
                    return NotFound(new Confirmation { Status = "error", ResponseMsg = "POSOrderItem not found" });
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{POSOrderItemId}/{DeletedBy}")]
        public ActionResult DeletePOSOrderItem(Int64 POSOrderItemId, int DeletedBy)
        {
            try
            {
                var pOSOrderItem = _context.POSOrderItems.SingleOrDefault(opt => opt.POSOrderItemId == POSOrderItemId);
                pOSOrderItem.IsDeleted = true;
                pOSOrderItem.UpdatedBy = DeletedBy;
                pOSOrderItem.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(pOSOrderItem);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
