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

namespace AdminApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FilterController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Filter> _filterRepo;
        public FilterController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Filter> filterRepo
                               )
        {
            _config = config;
            _context = context;
            _filterRepo = filterRepo;
        }
        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult CreateFilter(FilterDTO filter)
        {
            var objCheck = _context.Filters.SingleOrDefault(opt => opt.FilterName == filter.FilterName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {

                    Filter fil = new Filter();
                    fil.FilterName = filter.FilterName;
                    fil.Alias = filter.Alias;
                    fil.CreatedBy = filter.CreatedBy;
                    var obj = _filterRepo.Insert(fil);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Filter..!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [HttpGet]
        public ActionResult GetFilterList()
        {
            try
            {
                var list = (from u in _context.Filters

                            select new { u.FilterId, u.FilterName, u.Alias, u.IsDeleted }).Where(x => x.IsDeleted == false);



                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{id}")]
        public ActionResult GetSingleFilter(int id)
        {
            try
            {
                var singleCategory = _filterRepo.SelectById(id);
                return Ok(singleCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult UpdateFilter(UpdateFilterDTO updateFilterDTO)
        {
            try
            {
                var objFilter = _context.Filters.SingleOrDefault(opt => opt.FilterId == updateFilterDTO.FilterId);
                objFilter.FilterName = updateFilterDTO.FilterName;
                objFilter.Alias = updateFilterDTO.Alias;

                objFilter.UpdatedBy = updateFilterDTO.CreatedBy;
                objFilter.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objFilter);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin,User")]
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteFilter(int Id, int DeletedBy)
        {
            try
            {
                var objFilter = _context.Filters.SingleOrDefault(opt => opt.FilterId == Id);
                objFilter.IsDeleted = true;

                objFilter.UpdatedBy = DeletedBy;
                objFilter.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(objFilter);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }

}
