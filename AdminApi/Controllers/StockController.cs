using AdminApi.DTO.App.Purchase;
using AdminApi.Models;
using AdminApi.Models.App.Stock;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.Stock;
using AdminApi.DTO.App.ItemDTO;
using AdminApi.Models.App.Item;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StockController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Stock> _stockRepo;
        private readonly ISqlRepository<StockItems> _stockItemsRepo;
        public StockController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Stock> stockRepo,
                                ISqlRepository<StockItems> stockItemsRepo

                               )
        {
            _config = config;
            _context = context;
            _stockRepo = stockRepo;
            _stockItemsRepo = stockItemsRepo;

        }

        [HttpPost]
        public IActionResult CreateStock(StockDTO stockDTO)
        {
           
            try
            {
                    Stock stock = new Stock();
                    stock.LocationId = stockDTO.LocationId;
                    stock.SupplierId = stockDTO.SupplierId;
                    stock.Status = stockDTO.Status;
                    stock.ShippingCharges = stockDTO.ShippingCharges;
                    stock.TotalAmount = stockDTO.TotalAmount;
                    stock.AdditionalNotes = stockDTO.AdditionalNotes;
                    stock.CreatedBy = stockDTO.CreatedBy;
                    stock.CreatedOn = DateTime.Now;
                    var obj = _stockRepo.Insert(stock);
                for(int i= 0; i < stockDTO.StockItemsDTOs.Count; i++)
                {
                    StockItems stockItems = new StockItems();
                    stockItems.StockId = obj.StockId;
                    stockItems.ItemId = stockDTO.StockItemsDTOs[i].ItemId;
                    stockItems.Product = stockDTO.StockItemsDTOs[i].Product;
                    stockItems.Quantity = stockDTO.StockItemsDTOs[i].Quantity;
                    stockItems.UnitPrice = stockDTO.StockItemsDTOs[i].UnitPrice;
                    stockItems.SubTotal = stockDTO.StockItemsDTOs[i].SubTotal;
                    stockItems.CreatedBy = stockDTO.CreatedBy;
                    stockItems.CreatedOn = DateTime.Now;
                    var stocks = _stockItemsRepo.Insert(stockItems);

                }
                    return Ok(stockDTO);

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
                                u.IsDeleted,

                              StockItems = _context.StockItems
                                             .Where(x => x.StockId == u.StockId)
                                             .Select(x => new StockItemsDTO
                                             {
                                                 StockId = x.StockId,
                                                 ItemId = x.ItemId,
                                                 Product = x.Product,
                                                 Quantity = x.Quantity,
                                                 UnitPrice = x.UnitPrice,
                                                 SubTotal = x.SubTotal,
                                             }).ToList()

                            }).Where(x => x.IsDeleted == false).Distinct().ToList();
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{stockId}")]
        public ActionResult GetSingleStock(int stockId)
        {
            try
            {
                var list = (from u in _context.Stocks


                            join c in _context.StockItems on u.StockId equals c.StockId
                            select new
                            {
                                u.StockId,
                                u.LocationId,
                                u.SupplierId,
                                u.Status,
                                u.ShippingCharges,
                                u.TotalAmount,
                                u.AdditionalNotes,
                                u.CreatedOn,
                                u.IsDeleted,
                                
                                StockItems = _context.StockItems
                                                    .Where(stock => stock.StockId == u.StockId)
                                                    .Select(stock => new StockItemsDTO
                                                    {
                                                        StockId = stock.StockId,
                                                        ItemId = stock.ItemId,
                                                        Product = stock.Product,
                                                        Quantity = stock.Quantity,
                                                        UnitPrice = stock.UnitPrice,
                                                        SubTotal = stock.SubTotal,
                                                        CreatedBy = stock.CreatedBy
                                                    }).ToList(),
                            }).Where(x => x.StockId == stockId && x.IsDeleted == false).Distinct().ToList();

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
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
                    stock.Status = updateStockDTO.Status;
                    stock.ShippingCharges = updateStockDTO.ShippingCharges;
                    stock.TotalAmount = updateStockDTO.TotalAmount;
                    stock.AdditionalNotes = updateStockDTO.AdditionalNotes;
                    stock.UpdatedBy = updateStockDTO.UpdatedBy;
                    stock.UpdatedOn = System.DateTime.Now;
                    _context.SaveChanges();

                    foreach (var UpdateStockItemsDTO in updateStockDTO.UpdateStockItemsDTOs)
                    {
                        var stockItems = new StockItems
                        {
                            StockId = updateStockDTO.StockId,
                            ItemId = UpdateStockItemsDTO.ItemId,
                            Product = UpdateStockItemsDTO.Product,
                            Quantity = UpdateStockItemsDTO.Quantity,
                            UnitPrice = UpdateStockItemsDTO.UnitPrice,
                            SubTotal = UpdateStockItemsDTO.SubTotal,
                            UpdatedBy = UpdateStockItemsDTO.UpdatedBy,
                            UpdatedOn = DateTime.Now
                        };
                        _context.StockItems.Add(stockItems);

                    }
                    _context.SaveChanges();


                    return Ok(updateStockDTO);
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
