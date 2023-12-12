using AutoMapper;
using BankSystem.BL.Interface;
using BankSystem.DAL.Entities;
using BankSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [Route("~/Customers")]
        public IActionResult Index() => View(_mapper.Map<IEnumerable<Customer_VM>>(_unitOfWork.Customers.GetAll()));

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Customer_VM model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.Customers.Create(_mapper.Map<Customer>(model));
                    _unitOfWork.Complete();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("ModelError", ex.Message);
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
    }
}
