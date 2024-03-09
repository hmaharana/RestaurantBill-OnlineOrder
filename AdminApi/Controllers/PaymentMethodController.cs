using AdminApi.DTO.App.Location;
using AdminApi.Models;
using AdminApi.Models.App.Payment_Method;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.PaymentMethodDTO;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PaymentMethodController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PaymentMethod> _paymentMethodRepo;
        public PaymentMethodController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<PaymentMethod> paymentMethodRepo
                               )
        {
            _config = config;
            _context = context;
            _paymentMethodRepo = paymentMethodRepo;

        }
        [HttpPost]
        public IActionResult CreatePaymentMethod(PaymentMethodDTO paymentMethodDTO)
        {
            var objCheck = _context.PaymentMethods.SingleOrDefault(opt => opt.PaymentMethodName == paymentMethodDTO.PaymentMethodName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    PaymentMethod paymentMethod = new PaymentMethod();
                    paymentMethod.PaymentMethodName = paymentMethodDTO.PaymentMethodName;
                    paymentMethod.CreatedBy = paymentMethodDTO.CreatedBy;
                    var obj = _paymentMethodRepo.Insert(paymentMethod);
                    return Ok(obj);

                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate PaymentMethod!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetPaymentMethodList()
        {
            try
            {
                var list = (from u in _context.PaymentMethods
                          
                            select new
                            {
                                u.PaymentMethodId,
                                u.PaymentMethodName,
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
        [HttpGet("{paymentMethodId}")]
        public ActionResult GetSinglePaymentMethodId(int paymentMethodId)
        {
            try
            {
                var singlelocation = _paymentMethodRepo.SelectById(paymentMethodId);

                return Ok(singlelocation);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdatePaymentMethod(UpdatePaymentMenthodDTO updatePaymentMenthodDTO)
        {
            try
            {
                var paymentMethod = _context.PaymentMethods.SingleOrDefault(opt => opt.PaymentMethodId == updatePaymentMenthodDTO.PaymentMethodId);

                if (paymentMethod != null)
                {
                    paymentMethod.PaymentMethodName = updatePaymentMenthodDTO.PaymentMethodName;
                    paymentMethod.UpdatedBy = updatePaymentMenthodDTO.UpdatedBy;
                    paymentMethod.UpdatedOn = System.DateTime.Now;

                    _context.SaveChanges();

                    return Ok(paymentMethod);
                }
                else
                {
                    return NotFound(new Confirmation { Status = "error", ResponseMsg = "PaymentMethod not found" });
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{paymentMethodId}/{DeletedBy}")]
        public ActionResult DeletePaymentMethod(int paymentMethodId, int DeletedBy)
        {
            try
            {
                var paymentMethod = _context.PaymentMethods.SingleOrDefault(opt => opt.PaymentMethodId == paymentMethodId);
                paymentMethod.IsDeleted = true;
                paymentMethod.UpdatedBy = DeletedBy;
                paymentMethod.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
