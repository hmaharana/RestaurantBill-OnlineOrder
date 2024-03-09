using AdminApi.Models.App.Item;
using AdminApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Supplier;
using AdminApi.Models.App.Vendor;
using AdminApi.DTO.App.Vendor;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.Models.App.Purchase;
using AdminApi.DTO.App.Supplier;
using AdminApi.DTO.App.Purchase;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PurchaseController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Purchase> _purchaseRepo;
        public PurchaseController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Purchase> purchaseRepo
                               )
        {
            _config = config;
            _context = context;
            _purchaseRepo = purchaseRepo;

        }

        [HttpPost]
        public IActionResult CreatePurchase(PurchaseDTO purchaseDTO)
        {
            var objCheck = _context.Purchases.SingleOrDefault(opt => opt.SupplierId == purchaseDTO.SupplierId && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    Purchase purchase = new Purchase();
                    purchase.SupplierId = purchaseDTO.SupplierId;
                    purchase.ItemId = purchaseDTO.ItemId;
                    purchase.PurchaseDate = purchaseDTO.PurchaseDate;
                    purchase.PurchaseStatus = purchaseDTO.PurchaseStatus;
                    purchase.TotalAmount = purchaseDTO.TotalAmount;
                    purchase.PaymentStatus = purchaseDTO.PaymentStatus;
                    purchase.CreatedBy = purchaseDTO.CreatedBy;
                    var obj = _purchaseRepo.Insert(purchase);
                    return Ok(obj);

                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Hospital!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetPurchaseList()
        {
            try
            {
                var list = (from u in _context.Purchases
                            join a in _context.Suppliers on u.SupplierId equals a.SupplierId
                            join b in _context.Items on u.ItemId equals b.ItemId
                            select new
                            {
                                u.PurchaseId,
                                u.PurchaseDate,
                                u.PurchaseStatus,
                                u.TotalAmount,
                                u.PaymentStatus,
                                a.SupplierId,
                                a.SupplierName,
                                b.ItemId,
                                b.ItemName,
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

        [HttpGet("{purchaseId}")]
        public ActionResult GetSinglePurchaseId(int purchaseId)
        {
            try
            {
                var singlepurchase = _purchaseRepo.SelectById(purchaseId);

                return Ok(singlepurchase);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdatePurchase(UpdatePurchaseDTO updatePurchaseDTO)
        {
            try
            {
                var purchase = _context.Purchases.SingleOrDefault(opt => opt.PurchaseId == updatePurchaseDTO.PurchaseId);

                if (purchase != null)
                {
                    purchase.SupplierId = updatePurchaseDTO.SupplierId;
                    purchase.ItemId = updatePurchaseDTO.ItemId;
                    purchase.PurchaseDate = updatePurchaseDTO.PurchaseDate;
                    purchase.PurchaseStatus = updatePurchaseDTO.PurchaseStatus;
                    purchase.TotalAmount = updatePurchaseDTO.TotalAmount;
                    purchase.PaymentStatus = updatePurchaseDTO.PaymentStatus;
                    purchase.UpdatedBy = updatePurchaseDTO.UpdatedBy;
                    purchase.UpdatedOn = System.DateTime.Now;

                    _context.SaveChanges();

                    return Ok(purchase);
                }
                else
                {
                    return NotFound(new Confirmation { Status = "error", ResponseMsg = "Vendor not found" });
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{purchaseId}/{DeletedBy}")]
        public ActionResult DeletePurchase(int purchaseId, int DeletedBy)
        {
            try
            {
                var purchase = _context.Purchases.SingleOrDefault(opt => opt.PurchaseId == purchaseId);
                purchase.IsDeleted = true;
                purchase.UpdatedBy = DeletedBy;
                purchase.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(purchase);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
