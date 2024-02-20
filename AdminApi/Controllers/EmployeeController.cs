
using Microsoft.AspNetCore.Mvc;
using AdminApi;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.DTO;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminApi.Models.App.Employee;
using AdminApi.DTO.App.Employee;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Employee> _employeeRepo;
        public EmployeeController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Employee> employeeRepo
                               )
        {
            _config = config;
            _context = context;
            _employeeRepo = employeeRepo;

        }
        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDTO employeeDTO)
        {
            var objCheck = _context.Employees.SingleOrDefault(opt => opt.EmployeeName == employeeDTO.EmployeeName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    Employee employee = new Employee();
                    employee.EmployeeName = employeeDTO.EmployeeName;
                    employee.Email = employeeDTO.Email;
                    employee.MobNo = employeeDTO.MobNo;
                    employee.DateOfBirth = employeeDTO.DateOfBirth;
                    employee.DateOfJoining = employeeDTO.DateOfJoining;
                    employee.Address = employeeDTO.Address;
                    employee.Photo = employeeDTO.Photo;
                    employee.VendorId = employeeDTO.VendorId;
                    employee.CreatedBy = employeeDTO.CreatedBy;
                    var obj = _employeeRepo.Insert(employee);
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
        public ActionResult GetEmployeeList()
        {
            try
            {
                var list = (from u in _context.Employees
                            select new
                            {
                                u.EmployeeId,
                                u.EmployeeName,
                                u.Email,
                                u.MobNo,
                                u.DateOfBirth,
                                u.DateOfJoining,
                                u.Address,
                                u.Photo,
                                u.VendorId,
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

        [HttpGet("{employeeid}")]
        public ActionResult GetSingleEmployeeId(int employeeid)
        {
            try
            {
                var singleemployee = _employeeRepo.SelectById(employeeid);

                return Ok(singleemployee);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            try
            {
                var emp = _context.Employees.SingleOrDefault(opt => opt.EmployeeId == updateEmployeeDTO.EmployeeId);
                emp.EmployeeName = updateEmployeeDTO.EmployeeName;
                emp.Email = updateEmployeeDTO.Email;
                emp.MobNo = updateEmployeeDTO.MobNo;
                emp.DateOfBirth = updateEmployeeDTO.DateOfBirth;
                emp.DateOfJoining = updateEmployeeDTO.DateOfJoining;
                emp.Address = updateEmployeeDTO.Address;
                emp.Photo = updateEmployeeDTO.Photo;
                emp.VendorId = updateEmployeeDTO.VendorId;
                emp.UpdatedBy = updateEmployeeDTO.UpdatedBy;
                emp.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(emp);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{employeeid}/{DeletedBy}")]
        public ActionResult DeleteHospital(int employeeid, int DeletedBy)
        {
            try
            {
                var employee = _context.Employees.SingleOrDefault(opt => opt.EmployeeId == employeeid);
                employee.IsDeleted = true;
                employee.UpdatedBy = DeletedBy;
                employee.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
