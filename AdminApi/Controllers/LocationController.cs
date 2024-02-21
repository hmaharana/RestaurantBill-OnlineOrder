using AdminApi.Models.App.Vendor;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Location_Master;
using AdminApi.DTO.App.Vendor;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.Location;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LocationController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Location> _locationRepo;
        public LocationController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Location> locationRepo
                               )
        {
            _config = config;
            _context = context;
            _locationRepo = locationRepo;

        }
        [HttpPost]
        public IActionResult CreateLocation(LocationDTO locationDTO)
        {
            var objCheck = _context.Locations.SingleOrDefault(opt => opt.LocationName == locationDTO.LocationName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    Location location = new Location();
                    location.LocationName = locationDTO.LocationName;
                    location.VendorId = locationDTO.VendorId;
                    location.Latitude = locationDTO.Latitude;
                    location.Longitude = locationDTO.Longitude;
                    location.CreatedBy = locationDTO.CreatedBy;
                    var obj = _locationRepo.Insert(location);
                    return Ok(obj);

                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Location!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetLocationList()
        {
            try
            {
                var list = (from u in _context.Locations
                            join a in _context.Vendors on u.VendorId equals a.VendorId
                            select new
                            {
                                u.VendorId,
                                u.LocationId,
                                a.VendorName,
                                u.LocationName,
                                u.Longitude,
                                u.Latitude,
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
        [HttpGet("{locationId}")]
        public ActionResult GetSingleLocationId(int locationId)
        {
            try
            {
                var singlelocation = _locationRepo.SelectById(locationId);

                return Ok(singlelocation);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateLocation(UpdateLocationDTO updateLocationDTO)
        {
            try
            {
                var location = _context.Locations.SingleOrDefault(opt => opt.LocationId == updateLocationDTO.LocationId);

                if (location != null)
                {
                    location.LocationName = updateLocationDTO.LocationName;
                    location.VendorId = updateLocationDTO.VendorId;
                    location.Longitude = updateLocationDTO.Longitude;
                    location.Latitude = updateLocationDTO.Latitude;
                    location.UpdatedBy = updateLocationDTO.UpdatedBy;
                    location.UpdatedOn = System.DateTime.Now;

                    _context.SaveChanges();

                    return Ok(location);
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
        [HttpGet("{locationId}/{DeletedBy}")]
        public ActionResult DeleteLocation(int locationId, int DeletedBy)
        {
            try
            {
                var location = _context.Locations.SingleOrDefault(opt => opt.LocationId == locationId);
                location.IsDeleted = true;
                location.UpdatedBy = DeletedBy;
                location.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(location);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
