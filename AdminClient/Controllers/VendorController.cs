using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class VendorController : Controller
    {
        public IActionResult VendorCreate()
        {
            return View();
        }
        public IActionResult VendorList()
        {
            return View();
        }
        public IActionResult VendorEdit(int vendorId)
        {
            ViewBag.vendorId = vendorId;
            return View();
        }
    }
}
