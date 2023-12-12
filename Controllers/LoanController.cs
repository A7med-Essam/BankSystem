using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
