using BankSystem.BL.Interface;
using BankSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthRepository _repository;

        public AuthController(IAuthRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login_VM cred)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.Login(cred);
                    return RedirectToAction("Index", "Dashboard");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(cred);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register_VM cred)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.Register(cred);
                    return RedirectToAction("login", "Auth");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(cred);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _repository.SignOut();
            return RedirectToAction("login");
        }
    }
}
