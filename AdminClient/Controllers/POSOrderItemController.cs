using Microsoft.AspNetCore.Mvc;
using System;

namespace AdminClient.Controllers
{
    public class POSOrderItemController : Controller
    {
        public IActionResult POSOrderItemCreate()
        {
            return View();
        }
        public IActionResult POSOrderItemList()
        {
            return View();
        }
        public IActionResult POSOrderItemEdit(Int64 POSOrderItemId)
        {
            ViewBag.POSOrderItemId = POSOrderItemId;
            return View();
        }
    }
}
