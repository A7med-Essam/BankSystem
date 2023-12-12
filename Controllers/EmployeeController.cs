using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
