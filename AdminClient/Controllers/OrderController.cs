using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult OrderView()
        {
            return View();
        }
    }
}
