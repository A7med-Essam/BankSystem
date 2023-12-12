using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class ComplaintController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
