using AutoMapper;
using BankSystem.BL.Interface;
using BankSystem.DAL.Database;
using BankSystem.DAL.Entities;
using BankSystem.Models;

namespace BankSystem.BL.Repository
{
    public class Repository : IRepository
    {
        private readonly ApplicationContext _db;
        private readonly IMapper _mapper;


        public Repository(ApplicationContext db, IMapper mapper)
        {
            this._mapper = mapper;
            this._db = db;
        }
        public IEnumerable<Account_VM> GetAccounts()
        {
            var model = _mapper.Map<IEnumerable<Account_VM>>(_db.Accounts.ToList());
            return model;
        }

        public IEnumerable<Customer_VM> GetCustomers()
        {
            var model = _mapper.Map<IEnumerable<Customer_VM>>(_db.Customers.ToList());
            return model;
        }

        public void CreateAccount(Account_VM acc)
        {
            var model = _mapper.Map<Account>(acc);
            _db.Accounts.Add(model);
            _db.SaveChanges();
        }

        public void CreateCustomer(Customer_VM cs)
        {
            var customer = _db.Customers.Find(cs.NationalId);
            if (customer is null)
            {
                var model = _mapper.Map<Customer>(cs);
                _db.Customers.Add(model);
                _db.SaveChanges();
            }
            else
            {
                throw new InvalidDataException("Customer Exist");
            }

        }

        public void UpdateCustomer(Customer_VM cs)
        {
            var model = _mapper.Map<Customer>(cs);
            _db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
