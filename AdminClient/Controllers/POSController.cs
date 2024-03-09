using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class POSController : Controller
    {
        public IActionResult POS()
        {
            ViewBag.HideSidebar = true;
            return View();
        }
    }
}
