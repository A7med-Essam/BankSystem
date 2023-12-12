using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
