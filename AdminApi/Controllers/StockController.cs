using AdminApi.DTO.App.Purchase;
using AdminApi.Models;
using AdminApi.Models.App.Stock;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.Stock;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StockController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Stock> _stockRepo;
        public StockController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Stock> stockRepo
                               )
        {
            _config = config;
            _context = context;
            _stockRepo = stockRepo;

        }

        //[HttpPost]
        //public IActionResult CreateStock(StockDTO stockDTO)
        //{
        //    var objCheck = _context.Stocks.SingleOrDefault(opt => opt.LocationId == stockDTO.LocationId && opt.IsDeleted == false);
        //    try
        //    {
        //        if (objCheck == null)
        //        {
        //            Stock stock = new Stock();
        //            stock.LocationId = stockDTO.LocationId;
        //            stock.SupplierId = stockDTO.SupplierId;
        //            //stock.ItemId = stockDTO.ItemId;
        //            stock.Status = stockDTO.Status;
        //            stock.ShippingCharges = stockDTO.ShippingCharges;
        //            stock.TotalAmount = stockDTO.TotalAmount;
        //            stock.AdditionalNotes = stockDTO.AdditionalNotes;
        //            stock.CreatedBy = stockDTO.CreatedBy;
        //            var obj = _stockRepo.Insert(stock);
        //            return Ok(obj);

        //        }
        //        else if (objCheck != null)
        //        {
        //            return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Hospital!" });
        //        }
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}


        [HttpPost]
        public IActionResult CreateStock(StockDTO stockDTO)
        {
            try
            {
                var existingStock = _context.Stocks.SingleOrDefault(opt => opt.LocationId == stockDTO.LocationId && opt.IsDeleted == false);

                if (existingStock != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Hospital!" });
                }

                foreach (int itemId in stockDTO.ItemId)
                {
                    Stock stock = new Stock();
                    stock.LocationId = stockDTO.LocationId;
                    stock.SupplierId = stockDTO.SupplierId;
                    stock.Status = stockDTO.Status;
                    stock.ShippingCharges = stockDTO.ShippingCharges;
                    stock.TotalAmount = stockDTO.TotalAmount;
                    stock.AdditionalNotes = stockDTO.AdditionalNotes;
                    stock.CreatedBy = stockDTO.CreatedBy;
                    stock.ItemId = itemId; // Set the current item ID

                    var createdStock = _stockRepo.Insert(stock);
                }

                return Ok(new Confirmation { Status = "success", ResponseMsg = "Stock(s) created successfully!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet]
        public ActionResult GetStockList()
        {
            try
            {
                var list = (from u in _context.Stocks
                            join a in _context.Locations on u.LocationId equals a.LocationId
                            join b in _context.Suppliers on u.SupplierId equals b.SupplierId
                            join c in _context.Items on u.ItemId equals c.ItemId
                            select new
                            {
                                u.StockId,
                                u.Status,
                                u.ShippingCharges,
                                u.TotalAmount,
                                u.AdditionalNotes,
                                a.LocationId,
                                a.LocationName,
                                b.SupplierId,
                                b.SupplierName,
                                c.ItemId,
                                c.ItemName,
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

        [HttpGet("{stockId}")]
        public ActionResult GetSingleStockId(int stockId)
        {
            try
            {
                var singlestock = _stockRepo.SelectById(stockId);

                return Ok(singlestock);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateStock(UpdateStockDTO updateStockDTO)
        {
            try
            {
                var stock = _context.Stocks.SingleOrDefault(opt => opt.StockId == updateStockDTO.StockId);

                if (stock != null)
                {
                    stock.LocationId = updateStockDTO.LocationId;
                    stock.SupplierId = updateStockDTO.SupplierId;
                    stock.ItemId = updateStockDTO.ItemId;
                    stock.Status = updateStockDTO.Status;
                    stock.ShippingCharges = updateStockDTO.ShippingCharges;
                    stock.TotalAmount = updateStockDTO.TotalAmount;
                    stock.AdditionalNotes = updateStockDTO.AdditionalNotes;
                    stock.UpdatedBy = updateStockDTO.UpdatedBy;
                    stock.UpdatedOn = System.DateTime.Now;

                    _context.SaveChanges();

                    return Ok(stock);
                }
                else
                {
                    return NotFound(new Confirmation { Status = "error", ResponseMsg = "Stock not found" });
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{stockId}/{DeletedBy}")]
        public ActionResult DeleteStock(int stockId, int DeletedBy)
        {
            try
            {
                var stock = _context.Stocks.SingleOrDefault(opt => opt.StockId == stockId);
                stock.IsDeleted = true;
                stock.UpdatedBy = DeletedBy;
                stock.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(stock);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


    }
}
