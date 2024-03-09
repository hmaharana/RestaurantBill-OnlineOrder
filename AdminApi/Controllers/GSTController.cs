using AdminApi.Models.App.Vendor;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Tax;
using AdminApi.DTO.App.Vendor;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GSTController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<GST> _gstRepo;
        public GSTController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<GST> gstRepo
                               )
        {
            _config = config;
            _context = context;
            _gstRepo = gstRepo;

        }

        [HttpPost]
        public IActionResult CreateGST(GSTDTO gSTDTO)
        {
            var objCheck = _context.GSTs.SingleOrDefault(opt => opt.GSTName == gSTDTO.GSTName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    GST gST = new GST();
                    gST.GSTName = gSTDTO.GSTName;
                    gST.Percentage = gSTDTO.Percentage;
                    gST.CreatedBy = gSTDTO.CreatedBy;
                    var obj = _gstRepo.Insert(gST);
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
        public ActionResult GetGstList()
        {
            try
            {
                var list = (from u in _context.GSTs
                            select new
                            {
                                u.GSTId,
                                u.GSTName,
                                u.Percentage,
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
        [HttpGet("{gstId}")]
        public ActionResult GetSingleGstId(int gstId)
        {
            try
            {
                var singlegst = _gstRepo.SelectById(gstId);

                return Ok(singlegst);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateGST(UpdateGSTDTO updateGSTDTO)
        {
            try
            {
                var gst = _context.GSTs.SingleOrDefault(opt => opt.GSTId == updateGSTDTO.GSTId);

                if (gst != null)
                {
                    gst.GSTName = updateGSTDTO.GSTName;
                    gst.Percentage = updateGSTDTO.Percentage;
                    gst.UpdatedBy = updateGSTDTO.UpdatedBy;
                    gst.UpdatedOn = System.DateTime.Now;

                    _context.SaveChanges();

                    return Ok(gst);
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

        [HttpGet("{gstId}/{DeletedBy}")]
        public ActionResult DeleteGST(int gstId, int DeletedBy)
        {
            try
            {
                var gst = _context.GSTs.SingleOrDefault(opt => opt.GSTId == gstId);
                gst.IsDeleted = true;
                gst.UpdatedBy = DeletedBy;
                gst.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(gst);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
