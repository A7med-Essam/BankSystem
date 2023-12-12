using BankSystem.BL.Interface;
using BankSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRepository _repository;

        public CustomerController(IRepository repository)
        {
            this._repository = repository;
        }

        [Route("~/Customers")]
        public IActionResult Index()
        {
            return View(_repository.GetCustomers());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer_VM cs)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.CreateCustomer(cs);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("ModelError", ex.Message);
                    return View(cs);
                }
            }
            else
            {
                return View(cs);
            }
        }
    }
}
