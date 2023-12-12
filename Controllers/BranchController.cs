using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
