using BankSystem.BL.Interface;
using BankSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepository _repository;


        public AccountController(IRepository repository)
        {
            this._repository = repository;
        }
        [Route("~/Accounts")]
        public IActionResult Index()
        {
            return View(_repository.GetAccounts());

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create(Account_VM acc)
        {
            _repository.CreateAccount(acc);
            return RedirectToAction("Index");
        }
    }
}
