using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult SupplierCreate()
        {
            return View();
        }
        public IActionResult SupplierList()
        {
            return View();
        }

        public IActionResult SupplierEdit(int supplierId)
        {
            ViewBag.supplierId = supplierId;
            return View();
        }
    }
}
