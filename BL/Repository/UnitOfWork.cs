using BankSystem.BL.Interface;
using BankSystem.DAL.Database;
using BankSystem.DAL.Entities;


namespace BankSystem.BL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public IGenericRepository<Account> Accounts { get; private set; }

        public IGenericRepository<Customer> Customers { get; private set; }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Accounts = new GenericRepository<Account>(_context);
            Customers = new GenericRepository<Customer>(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
