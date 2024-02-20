using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult CreateEmployee()
        {
            return View();
        }

        public IActionResult EmployeeList()
        {
            return View();
        }
    }
}
