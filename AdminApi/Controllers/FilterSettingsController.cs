using AdminApi.DTO.App;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Nancy.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FilterSettingsController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<FilterSetting> _filterSettings;
        public FilterSettingsController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<FilterSetting> filterSettings
                               )
        {
            _config = config;
            _context = context;
            _filterSettings = filterSettings;

        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult CreateFilterSettings(FilterSettingsDTO filter)
        {
            var objCheck = _context.FilterSettings.SingleOrDefault(opt => opt.FilterId== filter.FilterId&& opt.IsDeleted == false && opt.FilterValueId== filter.FilterValueId && opt.CategoryId == filter.CategoryId);
            try
            {
                if (objCheck == null)
                {

                    FilterSetting fil = new FilterSetting();
                    fil.FilterId = filter.FilterId;
                    fil.FilterValueId = filter.FilterValueId;
                    fil.CategoryId = filter.CategoryId;
                    fil.CreatedBy = filter.CreatedBy;
                    fil.Order = filter.Order;
                    var obj = _filterSettings.Insert(fil);
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
                var list = (from u in _context.FilterSettings
                            join r in _context.Filters on u.FilterId equals r.FilterId
                            join fv in _context.FilterValues on u.FilterValueId equals fv.FilterValuesId
                            join c in _context.Category on u.CategoryId equals c.CategoryId

                            select new { u.FilterSettingId, u.FilterId, u.FilterValueId  , u.CategoryId,u.Order, r.FilterName,fv.FilterValueName, c.CategoryName, u.IsDeleted }).Where(x => x.IsDeleted == false).OrderBy(x=>x.Order);


                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{CategoryId}")]
        public ActionResult GetFilterValueListbyCategoryId(int CategoryId)
        {
            try
            {
                var list = (from u in _context.FilterSettings
                            join r in _context.Filters on u.FilterId equals r.FilterId
                            join fv in _context.FilterValues on u.FilterValueId equals fv.FilterValuesId
                            join c in _context.Category on u.CategoryId equals c.CategoryId

                            select new { u.FilterSettingId, u.FilterId, u.FilterValueId, u.CategoryId, u.Order, r.FilterName, fv.FilterValueName, c.CategoryName, u.IsDeleted }).Where(x => x.IsDeleted == false && x.CategoryId == CategoryId).OrderBy(x => x.Order).DistinctBy(y => new { y.FilterId, y.FilterName });


                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{FilterSettingId}")]
        public ActionResult GetSingleFilterSetting(int FilterSettingId)
        {
            try
            {
                var singleFilterSetting= _filterSettings.SelectById(FilterSettingId);
                return Ok(singleFilterSetting);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult UpdateFilterSetting(UpdateFilterSettingsDTO updateFilterSettingsDTO)
        {
            try
            {
                var objFilter = _context.FilterSettings.SingleOrDefault(opt => opt.FilterSettingId == updateFilterSettingsDTO.FilterSettingId);
                objFilter.FilterValueId = updateFilterSettingsDTO.FilterValueId;
                objFilter.FilterId = updateFilterSettingsDTO.FilterId;
                objFilter.CategoryId = updateFilterSettingsDTO.CategoryId;
                objFilter.UpdatedBy = updateFilterSettingsDTO.CreatedBy;
                objFilter.UpdatedOn = System.DateTime.Now;

                objFilter.Order = updateFilterSettingsDTO.Order;

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
        public ActionResult DeleteFilterSetting(int Id, int DeletedBy)
        {
            try
            {
                var objFilter = _context.FilterSettings.SingleOrDefault(opt => opt.FilterSettingId == Id);
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


        [HttpGet("{CategoryId}")]
        public ActionResult GetCombinations(int CategoryId)
        {
           
            List<object> resfilterSettingCombinations = new List<object> ();
            var propsValues = new OrderedDictionary() { };
            var list = (from u in _context.FilterSettings
                        join r in _context.Filters on u.FilterId equals r.FilterId
                        join fv in _context.FilterValues on u.FilterValueId equals fv.FilterValuesId
                        join c in _context.Category on u.CategoryId equals c.CategoryId

                        select new
                        {
                            u.FilterSettingId,
                            u.FilterId,
                            u.FilterValueId,
                            u.CategoryId,
                            r.FilterName,
                            fv.FilterValueName,
                            c.CategoryName,
                            u.IsDeleted,
                            u.Order
                        }).Where(x => x.IsDeleted == false && x.CategoryId == CategoryId).OrderBy(x=>x.Order).ToList();


            var filterlist = (from u in _context.FilterSettings
                        join r in _context.Filters on u.FilterId equals r.FilterId
                        join fv in _context.FilterValues on u.FilterValueId equals fv.FilterValuesId
                              join c in _context.Category on u.CategoryId equals c.CategoryId

                              select new
                        {
                          
                            u.FilterId,
                            r.FilterName,
                            u.CategoryId,
                            u.IsDeleted
                        }).Where(x => x.IsDeleted == false && x.CategoryId == CategoryId).Distinct().ToList();


            var filtervaluelist = (from u in _context.FilterSettings
                              join r in _context.Filters on u.FilterId equals r.FilterId
                              join fv in _context.FilterValues on u.FilterValueId equals fv.FilterValuesId
                                   join c in _context.Category on u.CategoryId equals c.CategoryId

                                   select new
                              {

                                  u.FilterId,
                                  r.FilterName,
                                  u.FilterValueId,
                                 fv.FilterValueName,
                                  u.CategoryId,
                                  u.IsDeleted
                              }).Where(x => x.IsDeleted == false && x.CategoryId == CategoryId).Distinct().ToList();

            for (int i = 0; i < filterlist.Count; i++)
            {
                List<String> filterSettingCombinations = new List<String>();
                for(int j=0;j< list.Count; j++)
                {
                    if (filterlist[i].FilterId == list[j].FilterId)
                    {
                       
                        filterSettingCombinations.Add(list[j].FilterValueId.ToString());

                    }
                }
                propsValues.Add(filterlist[i].FilterName, filterSettingCombinations);
            }
            if (propsValues.Count > 0)
            {
                var propsIndexes = new Dictionary<String, IndexData>();
                var propsKeys = new List<String>();

                foreach (var key in propsValues.Keys)
                {
                    propsKeys.Add((String)key);
                    propsIndexes.Add((String)key, new IndexData() { PropIndex = 0, MaxCount = (propsValues[key] as List<String>).Count });
                }

                int propCount = propsValues.Count;
                String lastKey = propsKeys[propCount - 1];

                // count the permutations until the "most significant" property (the one changing least often) has reached its count
                for (int combinationIndex = 0; ; combinationIndex++)
                {
                    var sb = new StringBuilder();
                    sb.AppendFormat("{0}: ", combinationIndex + 1);
                    List<String> filterSettingCombinations1 = new List<String>();
                    foreach (var key in propsValues.Keys)
                    {
                        int propIndex = propsIndexes[(String)key].PropIndex;
                        sb.AppendFormat("{0} ", ((propsValues[(String)key] as List<String>)[propIndex]));
                        filterSettingCombinations1.Add(((propsValues[(String)key] as List<String>)[propIndex]));
                    }

                    resfilterSettingCombinations.Add(filterSettingCombinations1);
                    // incrementing indexes
                    bool exit = false;
                    propsIndexes[lastKey].PropIndex++;

                    for (int i = propCount - 1; i >= 0; i--)
                    {
                        String propKey = (String)propsKeys[i];

                        // current index has reached its count - incrementing previous one and resetting current one
                        if (propsIndexes[propKey].PropIndex >= propsIndexes[propKey].MaxCount)
                        {
                            propsIndexes[propKey].PropIndex = 0;

                            // "most significant" property has reached its count
                            if (i == 0)
                            {
                                exit = true;
                                break;
                            }

                            String prevPropKey = (String)propsKeys[i - 1];
                            propsIndexes[prevPropKey].PropIndex++;
                        }
                    }

                    if (exit)
                        break;
                }

                return Ok(new { filters = filterlist, filterValue = filtervaluelist, combinations = resfilterSettingCombinations, });
            }
            return Ok();
        }
    }
}







