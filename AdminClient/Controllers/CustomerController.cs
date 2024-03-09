using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerCreate()
        {
            return View();
        }
        public IActionResult CustomerList()
        {
            return View();
        }
     
    }
}
