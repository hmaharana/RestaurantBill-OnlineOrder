using AdminApi.Models.App.Category;
using AdminApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Item;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using Microsoft.AspNetCore.Authorization;
using AdminApi.DTO.App.ItemDTO;


namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class ItemController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Item> _itemRepo;

        public ItemController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Item> itemRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _itemRepo = itemRepo;

        }
        
        [HttpPost]
        public ActionResult CreateItem(ItemDTO itemDTO)
        {
            var objCheck = _context.Items.SingleOrDefault(opt => opt.ItemName == itemDTO.ItemName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    Item item = new Item();
                    item.ItemName = itemDTO.ItemName;
                    item.VendorId = itemDTO.VendorId;
                    item.CategoryId = itemDTO.CategoryId;
                    item.SalePrice = itemDTO.SalePrice;
                    item.MRP = itemDTO.MRP;
                    item.DiscountAmount = itemDTO.DiscountAmount;
                    item.TaxType = itemDTO.TaxType;
                    item.ItemImage = itemDTO.ItemImage;
                    item.Description = itemDTO.Description;
                    item.CreatedBy = itemDTO.CreatedBy;
                    var obj = _itemRepo.Insert(item);
                    return Ok(obj);

                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Category.." });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult AllItemList()
        {
            try
            {
                var list = (from u in _context.Items
                            select new
                            {
                                u.ItemId,
                                u.ItemName,
                                u.CreatedOn,
                                u.IsDeleted,
                                u.VendorId,
                                u.CategoryId,
                                u.SalePrice,
                                u.MRP,
                                u.DiscountAmount,
                                u.TaxType,
                                u.ItemImage,
                                u.Description,
                            }).Where(x => x.IsDeleted == false);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{ItemId}")]
        public ActionResult GetSingleItem(int ItemId)
        {
            try
            {
                var category = _itemRepo.SelectById(ItemId);

                return Ok(category);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
       
        [HttpPost]
        public ActionResult UpdateItem(ItemUpdateDTO itemUpdateDTO)
        {
            try
            {
                var item = _context.Items.SingleOrDefault(opt => opt.ItemId == itemUpdateDTO.ItemId);
                item.ItemName = itemUpdateDTO.ItemName;
                item.VendorId = itemUpdateDTO.VendorId;
                item.CategoryId = itemUpdateDTO.CategoryId;
                item.SalePrice = itemUpdateDTO.SalePrice;
                item.MRP = itemUpdateDTO.MRP;
                item.DiscountAmount = itemUpdateDTO.DiscountAmount;
                item.TaxType = itemUpdateDTO.TaxType;
                item.ItemImage = itemUpdateDTO.ItemImage;
                item.Description = itemUpdateDTO.Description;
                item.UpdatedBy = itemUpdateDTO.UpdatedBy;
                item.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(item);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
      
        [HttpGet("{ItemId}/{DeletedBy}")]
        public ActionResult DeleteItem(int ItemId, int DeletedBy)
        {
            try
            {
                var item = _context.Items.SingleOrDefault(opt => opt.ItemId == ItemId);
                item.IsDeleted = true;
                item.UpdatedBy = DeletedBy;
                item.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(item);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }

}
