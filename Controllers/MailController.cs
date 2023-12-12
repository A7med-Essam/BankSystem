using BankSystem.BL.Helper;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendMail()
        {
            MailHelper.Send();
            return RedirectToAction("Index");
        }

        public IActionResult Upload(IFormFile file)
        {
            UploadHelper.Upload(file);
            return RedirectToAction("Index");
        }
    }
}
