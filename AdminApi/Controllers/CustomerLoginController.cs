using AdminApi.Models.App.Category;
using AdminApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.CustomerLogin;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Text;
using System.Security.Cryptography;
using AdminApi.DTO.App.CustomerLoginDTO;
using System.Linq;

namespace AdminApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CustomerLoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<CustomerLogin> _customerLoginRepo;
       
       
        public CustomerLoginController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<CustomerLogin> CustomerLoginsRepo)
        {
            _config = config;
            _context = context;
            _customerLoginRepo = CustomerLoginsRepo;
           
        }

        [AllowAnonymous]
        [HttpGet("{CustomerMobNo}/{PassWord}")]
        public ActionResult CustomerLogin(string CustomerMobNo, string Password)
        {

            try
            {
                string encryptedPassword = EncryptPassword(Password);
                var list = (from u in _context.CustomerLogins
                            select new
                            {
                                u.CustomerLoginId,
                                u.CustomerName,
                                u.CustomerMobNo,
                                u.Email,
                                u.Password,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CustomerMobNo == CustomerMobNo && x.Password == encryptedPassword).FirstOrDefault();

                if (list != null)
                {
                    return Ok(list);
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        private string EncryptPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(bytes);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("x2"));
            }
            return result.ToString();
        }

        [HttpPost]
        public IActionResult CustomerCreate(CustomerLoginDTO customerLoginDTO)
        {
            var objcheck = _context.CustomerLogins.SingleOrDefault(opt => opt.CustomerName == customerLoginDTO.CustomerName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    CustomerLogin customerLogin = new CustomerLogin();
                    customerLogin.CustomerName = customerLogin.CustomerName;
                    customerLogin.CustomerMobNo = customerLogin.CustomerMobNo;
                    customerLogin.Email = customerLogin.Email;
                    customerLogin.Password = EncryptPassword(customerLoginDTO.Password);
                    customerLogin.CreatedBy = customerLogin.CreatedBy;
                    customerLogin.CreatedOn = System.DateTime.Now;
                    var obj = _customerLoginRepo.Insert(customerLogin);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate User Id..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        [HttpGet("{UserId}")]
        public ActionResult GetCustomerListbyuserid(int UserId)
        {
            try
            {
                var list = (from u in _context.CustomerLogins
                            join a in _context.Users on u.CreatedBy equals a.UserId
                            select new
                            {
                                a.UserId,
                                a.UserName,
                                u.CustomerLoginId,
                                u.CustomerName,
                                u.CustomerMobNo,
                                u.Email,
                                u.Password,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.UserId == UserId).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //single list
        [HttpGet("{CustomerLoginId}")]
        public ActionResult GetSingleCustomer(int CustomerLoginId)
        {
            try
            {
                var singleAgent = _customerLoginRepo.SelectById(CustomerLoginId);
                return Ok(singleAgent);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult updateCustomer(CustomerLoginUpdateDTO customerLoginUpdateDTO)
        {
            try
            {
                var objCustomer = _context.CustomerLogins.SingleOrDefault(opt => opt.CustomerLoginId == customerLoginUpdateDTO.CustomerLoginId);
                objCustomer.CustomerLoginId = customerLoginUpdateDTO.CustomerLoginId;
                objCustomer.CustomerName = customerLoginUpdateDTO.CustomerName;
                objCustomer.CustomerMobNo = customerLoginUpdateDTO.CustomerMobNo;
                objCustomer.Email = customerLoginUpdateDTO.Email;
                objCustomer.Password = EncryptPassword(customerLoginUpdateDTO.Password);
                objCustomer.UpdatedBy = customerLoginUpdateDTO.UpdatedBy;
                objCustomer.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCustomer);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteCustomer(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.CustomerLogins.SingleOrDefault(opt => opt.CustomerLoginId == Id);
                objabout.IsDeleted = true;
                objabout.UpdatedBy = DeletedBy;
                objabout.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
