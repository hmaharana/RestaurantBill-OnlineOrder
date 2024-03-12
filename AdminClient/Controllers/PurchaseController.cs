using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult PurchaseCreate()
        {
            return View();
        }
        public IActionResult PurchaseList()
        {
            return View();
        }
        public IActionResult PurchaseEdit(int purchaseId)
        {
            ViewBag.purchaseId = purchaseId;
            return View();
        }
    }
}
