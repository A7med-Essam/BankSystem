using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
