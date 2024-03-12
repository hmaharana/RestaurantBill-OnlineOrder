using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class PaymentMethodController : Controller
    {
        public IActionResult PaymentMethodCreate()
        {
            return View();
        }
        public IActionResult PaymentMethodList()
        {
            return View();
        }
        public IActionResult PaymentMethodEdit(int paymentMethodId)
        {
            ViewBag.paymentMethodId = paymentMethodId;
            return View();
        }
    }
}
