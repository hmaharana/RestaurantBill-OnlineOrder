using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App.Employee
{
    public class EmployeeDTO
    {
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string MobNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public int? VendorId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateEmployeeDTO
    {
        public int EmployeeId { get; set; }
        public int? VendorId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string MobNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
