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

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FilterValueController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<FilterValues> _filterValues;
        public FilterValueController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<FilterValues> filterValues
                               )
        {
            _config = config;
            _context = context;
            _filterValues = filterValues;

        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult CreateFilterValues(FilterValueDTO filter)
        {
            var objCheck = _context.FilterValues.SingleOrDefault(opt => opt.FilterValueName == filter.FilterValueName && opt.IsDeleted == false && opt.FilterId== filter.FilterId);
            try
            {
                if (objCheck == null)
                {

                    FilterValues fil = new FilterValues();
                    fil.FilterValueName = filter.FilterValueName;
                    fil.FilterId = filter.FilterId;
                    fil.CreatedBy = filter.CreatedBy;
                    var obj = _filterValues.Insert(fil);
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
        public ActionResult GetFilterValueList()
        {
            try
            {
                var list = (from u in _context.FilterValues
                            join r in _context.Filters on
                            u.FilterId equals r.FilterId
                            select new { u.FilterValuesId, u.FilterValueName, u.FilterId, r.FilterName, u.IsDeleted}).Where(x => x.IsDeleted == false);





                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [HttpGet("{FilterId}")]
        public ActionResult GetFilterValueListByFilterId(int FilterId)
        {
            try
            {
                var list = (from u in _context.FilterValues
                            join r in _context.Filters on
                            u.FilterId equals r.FilterId
                            select new { u.FilterValuesId, u.FilterValueName, u.FilterId, r.FilterName, u.IsDeleted }).Where(x => x.IsDeleted == false && x.FilterId== FilterId);





                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{FilterValueId}")]
        public ActionResult GetSingleFilterValue(int FilterValueId)
        {
            try
            {
                var singleFilterValue = _filterValues.SelectById(FilterValueId);
                return Ok(singleFilterValue);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult UpdateFilterValue(UpdateFilterValueDTO updateFilterDTO)
        {
            try
            {
                var objFilter = _context.FilterValues.SingleOrDefault(opt => opt.FilterValuesId == updateFilterDTO.FilterValuesId);
                objFilter.FilterValueName = updateFilterDTO.FilterValueName;
                objFilter.FilterId = updateFilterDTO.FilterId;
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
        public ActionResult DeleteFilterValue(int Id, int DeletedBy)
        {
            try
            {
                var objFilter = _context.FilterValues.SingleOrDefault(opt => opt.FilterValuesId == Id);
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
