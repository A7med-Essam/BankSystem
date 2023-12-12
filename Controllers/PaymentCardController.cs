using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class PaymentCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
