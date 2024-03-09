using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class GSTController : Controller
    {
        public IActionResult GSTCreate()
        {
            return View();
        }
        public IActionResult GSTList()
        {
            return View();
        }

        public IActionResult GSTEdit(int gstId)
        {
            ViewBag.gstId = gstId;
            return View();
        }
    }
}

