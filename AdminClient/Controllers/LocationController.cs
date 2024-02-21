using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult LocationCreate()
        {
            return View();
        }
        public IActionResult LocationList()
        {
            return View();
        }
        public IActionResult LocationEdit(int locationId)
        {
            ViewBag.locationId = locationId;
            return View();
        }
    }
}
