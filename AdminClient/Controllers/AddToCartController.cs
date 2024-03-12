using Microsoft.AspNetCore.Mvc;
using System;

namespace AdminClient.Controllers
{
    public class AddToCartController : Controller
    {
        public IActionResult AddToCartCreate()
        {
            return View();
        }
        public IActionResult AddToCartList()
        {
            return View();
        }
        public IActionResult AddToCartEdit(int AddToCartId)
        {
            ViewBag.AddToCartId = AddToCartId;
            return View();
        }
    }
}
