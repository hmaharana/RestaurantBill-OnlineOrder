using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CityController : Controller
    {
        public IActionResult CityCreate()
        {
            return View();
        }
    }
}
