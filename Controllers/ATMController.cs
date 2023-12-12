using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class ATMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
