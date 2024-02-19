
using AdminApi.DTO.App;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminApi.Controllers;
using AdminApi.Models.App.Vendor;
using AdminApi.DTO.App.Vendor;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class VendorController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Vendor> _vendorRepo;
        public VendorController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Vendor> vendorRepo
                               )
        {
            _config = config;
            _context = context;
            _vendorRepo = vendorRepo;

        }

        [HttpPost]
        public IActionResult CreateVendor(VendorDTO vendorDTO)
        {
            var objCheck = _context.Vendors.SingleOrDefault(opt => opt.VendorName == vendorDTO.VendorName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    Vendor vendor = new Vendor();
                    vendor.VendorName = vendorDTO.VendorName;
                    vendor.Email = vendorDTO.Email;
                    vendor.MobileNo = vendorDTO.MobileNo;
                    vendor.AadharNo = vendorDTO.AadharNo;
                    vendor.PANNo = vendorDTO.PANNo;
                    vendor.Image = vendorDTO.Image;
                    vendor.Certificate = vendorDTO.Certificate;
                    vendor.CreatedBy = vendorDTO.CreatedBy;
                    var obj = _vendorRepo.Insert(vendor);
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
        public ActionResult GetVendorList()
        {
            try
            {
                var list = (from u in _context.Vendors
                            select new
                            {
                                u.VendorId,
                                u.VendorName,
                                u.Email,
                                u.MobileNo,
                                u.AadharNo,
                                u.PANNo,
                                u.Image,
                                u.Certificate,
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

        [HttpGet("{vendorId}")]
        public ActionResult GetSingleVendorId(int vendorId)
        {
            try
            {
                var singlevendor = _vendorRepo.SelectById(vendorId);

                return Ok(singlevendor);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateVendor(UpdateVendorDTO updateVendorDTO)
        {
            try
            {
                var vendor = _context.Vendors.SingleOrDefault(opt => opt.VendorId == updateVendorDTO.VendorId);

                if (vendor != null)
                {
                    vendor.VendorName = updateVendorDTO.VendorName;
                    vendor.Email = updateVendorDTO.Email;
                    vendor.MobileNo = updateVendorDTO.MobileNo;
                    vendor.AadharNo = updateVendorDTO.AadharNo;
                    vendor.PANNo = updateVendorDTO.PANNo;

                    
                    if (!string.IsNullOrEmpty(updateVendorDTO.Image))
                    {
                        vendor.Image = updateVendorDTO.Image;
                    }

                   
                    if (!string.IsNullOrEmpty(updateVendorDTO.Certificate))
                    {
                        vendor.Certificate = updateVendorDTO.Certificate;
                    }

                    vendor.UpdatedBy = updateVendorDTO.UpdatedBy;
                    vendor.UpdatedOn = System.DateTime.Now;

                    _context.SaveChanges();

                    return Ok(vendor);
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

        [HttpGet("{vendorId}/{DeletedBy}")]
        public ActionResult DeleteVendor(int vendorId, int DeletedBy)
        {
            try
            {
                var vendor = _context.Vendors.SingleOrDefault(opt => opt.VendorId == vendorId);
                vendor.IsDeleted = true;
                vendor.UpdatedBy = DeletedBy;
                vendor.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(vendor);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


    }
}
