using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class FilterValueController : Controller
    {
        public IActionResult FilterValueList()
        {
            return View();
        }
    }
}
