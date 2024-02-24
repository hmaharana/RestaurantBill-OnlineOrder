using AdminApi.DTO.App.Location;
using AdminApi.Models;
using AdminApi.Models.App.Location_Master;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.Vendor;
using AdminApi.Models.App.Vendor;
using NetTopologySuite.Geometries;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CityController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<City> _cityRepo;
        public CityController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<City> cityRepo
                               )
        {
            _config = config;
            _context = context;
            _cityRepo = cityRepo;

        }

        [HttpPost]
        public IActionResult CreateCity(CityDTO cityDTO)
        {
            var objCheck = _context.Cities.SingleOrDefault(opt => opt.CityName == cityDTO.CityName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    City city = new City();
                    city.CityName = cityDTO.CityName;
                    city.VendorId = cityDTO.VendorId;
                    city.CreatedBy = cityDTO.CreatedBy;
                    var obj = _cityRepo.Insert(city);
                    return Ok(obj);

                }

                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate City!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetCityList()
        {
            try
            {
                var list = (from u in _context.Cities
                            join a in _context.Vendors on u.VendorId equals a.VendorId
                            select new
                            {
                                u.VendorId,
                                u.CityId,
                                a.VendorName,
                                u.CityName,
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

        [HttpGet("{cityId}")]
        public ActionResult GetSingleCityId(int cityId)
        {
            try
            {
                var singlecity = _cityRepo.SelectById(cityId);

                return Ok(singlecity);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateCity(UpdateCityDTO updateCityDTO)
        {
            try
            {
                var city = _context.Cities.SingleOrDefault(opt => opt.CityId == updateCityDTO.CityId);

                if (city != null)
                {
                    city.CityName = updateCityDTO.CityName;
                    city.VendorId = updateCityDTO.VendorId;
                    city.UpdatedBy = updateCityDTO.UpdatedBy;
                    city.UpdatedOn = System.DateTime.Now;

                    _context.SaveChanges();

                    return Ok(city);
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

        [HttpGet("{cityId}/{DeletedBy}")]
        public ActionResult DeleteCity(int cityId, int DeletedBy)
        {
            try
            {
                var city = _context.Cities.SingleOrDefault(opt => opt.CityId == cityId);
                city.IsDeleted = true;
                city.UpdatedBy = DeletedBy;
                city.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(city);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
