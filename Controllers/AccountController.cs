using AutoMapper;
using BankSystem.BL.Interface;
using BankSystem.DAL.Entities;
using BankSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AccountController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [Route("~/Accounts")]
        public IActionResult Index() => View(_mapper.Map<IEnumerable<Account_VM>>(_unitOfWork.Accounts.GetAll()));

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create(Account_VM acc)
        {
            _unitOfWork.Accounts.Create(_mapper.Map<Account>(acc));
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }
    }
}
