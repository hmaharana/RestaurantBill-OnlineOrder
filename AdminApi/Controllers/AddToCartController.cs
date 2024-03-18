using AdminApi.Models.App.Order;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using AdminApi.Models.App.Add_To_Cart;
using AdminApi.DTO.App.AddToCartDTO;
using System.Linq;
using AdminApi.DTO.App.ItemDTO;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AddToCartController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<AddToCart> _addToCartRepo;
        public AddToCartController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<AddToCart> addToCartRepo
                               )
        {
            _config = config;
            _context = context;
            _addToCartRepo = addToCartRepo;

        }
        [HttpPost]
        public IActionResult CreateAddToCart(AddTOCartDTO addTOCartDTO)
        {
            try
            {
                var objCheck = _context.AddToCarts.SingleOrDefault(x => x.ItemId == addTOCartDTO.ItemId && x.IsDeleted == false);
                if (objCheck == null)
                {
                    AddToCart addToCart = new AddToCart();
                    addToCart.ItemId = addTOCartDTO.ItemId;
                    addToCart.VendorId = addTOCartDTO.VendorId;
                    addToCart.Quantity = addTOCartDTO.Quantity;
                    addToCart.Price = addTOCartDTO.Price;
                    addToCart.TotalPrice = addTOCartDTO.TotalPrice;
                    addToCart.CreatedBy = addTOCartDTO.CreatedBy;
                    var obj = _addToCartRepo.Insert(addToCart);
                    return Ok(obj);


                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate AddToCart!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }


        }
        [HttpGet]
        public ActionResult GetAddToCartList()
        {
            try
            {
                var list = (from u in _context.AddToCarts
                            join a in _context.Vendors on u.VendorId equals a.VendorId
                            join b in _context.Items on u.ItemId equals b.ItemId
                            join c in _context.ItemImage on u.ItemId equals c.ItemId
                            select new
                            {
                                u.VendorId,
                                u.AddToCartId,
                                a.VendorName,
                                u.ItemId,
                                b.ItemName,
                                u.Quantity,
                                u.Price,
                                u.TotalPrice,
                                u.IsDeleted,
                                 ItemImages = _context.ItemImage
                                                    .Where(img => img.ItemId == u.ItemId)
                                                    .Select(img => new ItemImageViewDTO
                                                    {
                                                        ItemId = img.ItemId,
                                                        MainImage = img.MainImage,
                                                        CreatedOn = img.CreatedOn,
                                                        CreatedBy = img.CreatedBy
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
        [HttpGet("{AddToCartId}")]
        public ActionResult GetSingleAddToCartId(int AddToCartId)
        {
            try
            {
                var list = (from u in _context.AddToCarts
                           
                            join c in _context.ItemImage on u.ItemId equals c.ItemId
                            select new
                            {
                                u.VendorId,
                                u.AddToCartId,
                                u.ItemId,
                                u.Quantity,
                                u.Price,
                                u.TotalPrice,
                                u.IsDeleted,
                                ItemImages = _context.ItemImage
                                                    .Where(img => img.ItemId == u.ItemId)
                                                    .Select(img => new ItemImageViewDTO
                                                    {
                                                        ItemId = img.ItemId,
                                                        MainImage = img.MainImage,
                                                        CreatedOn = img.CreatedOn,
                                                        CreatedBy = img.CreatedBy
                                                    }).ToList(),
                            }).Where(x => x.AddToCartId == AddToCartId && x.IsDeleted == false).Distinct().ToList();
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateAddToCart(UpdateAddToCartDTO updateAddToCartDTO)
        {
            try
            {
                var addToCart = _context.AddToCarts.SingleOrDefault(x => x.AddToCartId == updateAddToCartDTO.AddToCartId);
                if (addToCart != null)
                {
                    addToCart.VendorId = updateAddToCartDTO.VendorId;
                    addToCart.ItemId = updateAddToCartDTO.ItemId;
                    addToCart.Quantity = updateAddToCartDTO.Quantity;
                    addToCart.Price = updateAddToCartDTO.Price;
                    addToCart.TotalPrice = updateAddToCartDTO.TotalPrice;
                    addToCart.UpdatedBy = updateAddToCartDTO.CreatedBy;
                    addToCart.UpdatedOn = System.DateTime.Now;
                    _context.SaveChanges();
                    return Ok(addToCart);
                }
                else
                {
                    return NotFound(new Confirmation { Status = "error", ResponseMsg = "AddToCart not found" });
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{AddToCartId}/{DeletedBy}")]
        public ActionResult DeleteAddToCart(int AddToCartId, int DeletedBy)
        {
            try
            {
                var addToCart = _context.AddToCarts.SingleOrDefault(opt => opt.AddToCartId == AddToCartId);
                addToCart.IsDeleted = true;
                addToCart.UpdatedBy = DeletedBy;
                addToCart.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(addToCart);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdatePlusQuantity(UpdateAddToCartDTO updateAddToCartDTO)
        {
            try
            {
                var addToCart = _context.AddToCarts.SingleOrDefault(x => x.AddToCartId ==  updateAddToCartDTO.AddToCartId);
                addToCart.Quantity = addToCart.Quantity + 1;
                addToCart.UpdatedBy = updateAddToCartDTO.CreatedBy;
                addToCart.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(addToCart);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateMinusQuantity(UpdateAddToCartDTO updateAddToCartDTO)
        {
            try
            {
                var addToCart = _context.AddToCarts.SingleOrDefault(x => x.AddToCartId == updateAddToCartDTO.AddToCartId);
                addToCart.Quantity = addToCart.Quantity - 1;
                addToCart.UpdatedBy = updateAddToCartDTO.CreatedBy;
                addToCart.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(addToCart);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
