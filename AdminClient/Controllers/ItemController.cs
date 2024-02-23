using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult ItemCreate()
        {
            return View();
        }
        public IActionResult ItemList()
        {
            return View();
        }
        public IActionResult ItemEdit(int ItemId)
        {
            ViewBag.ItemId = ItemId;
            return View();
        }
    }
}
