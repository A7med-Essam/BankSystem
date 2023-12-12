using BankSystem.DAL.Entities;

namespace BankSystem.BL.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Account> Accounts { get; }
        IGenericRepository<Customer> Customers { get; }

        int Complete();
    }
}
