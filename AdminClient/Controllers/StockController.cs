using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class StockController : Controller
    {
        public IActionResult StockCreate()
        {
            return View();
        }
        public IActionResult StockList()
        {
            return View();
        }
    }
}
