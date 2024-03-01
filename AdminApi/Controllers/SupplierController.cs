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
using AdminApi.DTO.App.Supplier;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SupplierController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Supplier> _supplierRepo;
        public SupplierController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Supplier> supplierRepo
                               )
        {
            _config = config;
            _context = context;
            _supplierRepo = supplierRepo;

        }
        [HttpPost]
        public IActionResult CreateSupplier(SupplierDTO supplierDTO)
        {
            var objCheck = _context.Suppliers.SingleOrDefault(opt => opt.SupplierName == supplierDTO.SupplierName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierName = supplierDTO.SupplierName;
                    supplier.MobileNo = supplierDTO.MobileNo;
                    supplier.SupplierEmail = supplierDTO.SupplierEmail;
                    supplier.GSTId = supplierDTO.GSTId;
                    supplier.PayTerm = supplierDTO.PayTerm;
                    supplier.SupplierAddress = supplierDTO.SupplierAddress;
                    supplier.TotalPurchase = supplierDTO.TotalPurchase;
                    supplier.VendorId = supplierDTO.VendorId;
                    supplier.CreatedBy = supplierDTO.CreatedBy;
                    var obj = _supplierRepo.Insert(supplier);
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
        public ActionResult GetSupplierList()
        {
            try
            {
                var list = (from u in _context.Suppliers
                            join a in _context.Vendors on u.VendorId equals a.VendorId
                            join b in _context.GSTs on u.GSTId equals b.GSTId
                            select new
                            {
                                u.SupplierId,
                                u.SupplierName,
                                u.MobileNo,
                                u.SupplierEmail,
                                u.GSTId,
                                u.PayTerm,
                                u.SupplierAddress,
                                u.TotalPurchase,
                                u.VendorId,
                                a.VendorName,
                                b.GSTName,
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
        [HttpGet("{supplierId}")]
        public ActionResult GetSingleSupplierId(int supplierId)
        {
            try
            {
                var singlesupplier = _supplierRepo.SelectById(supplierId);

                return Ok(singlesupplier);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateSupplier(UpdateSupplierDTO updateSupplierDTO)
        {
            try
            {
                var supplier = _context.Suppliers.SingleOrDefault(opt => opt.SupplierId == updateSupplierDTO.SupplierId);

                if (supplier != null)
                {
                    supplier.SupplierName = updateSupplierDTO.SupplierName;
                    supplier.MobileNo = updateSupplierDTO.MobileNo;
                    supplier.SupplierEmail = updateSupplierDTO.SupplierEmail;
                    supplier.GSTId = updateSupplierDTO.GSTId;
                    supplier.PayTerm = updateSupplierDTO.PayTerm;
                    supplier.SupplierAddress = updateSupplierDTO.SupplierAddress;
                    supplier.TotalPurchase = updateSupplierDTO.TotalPurchase;
                    supplier.VendorId = updateSupplierDTO.VendorId;
                    supplier.UpdatedBy = updateSupplierDTO.UpdatedBy;
                    supplier.UpdatedOn = System.DateTime.Now;

                    _context.SaveChanges();

                    return Ok(supplier);
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

        [HttpGet("{supplierId}/{DeletedBy}")]
        public ActionResult DeleteVendor(int supplierId, int DeletedBy)
        {
            try
            {
                var supplier = _context.Suppliers.SingleOrDefault(opt => opt.SupplierId == supplierId);
                supplier.IsDeleted = true;
                supplier.UpdatedBy = DeletedBy;
                supplier.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(supplier);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
