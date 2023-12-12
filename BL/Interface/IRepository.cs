using BankSystem.Models;

namespace BankSystem.BL.Interface
{
    public interface IRepository
    {
        IEnumerable<Account_VM> GetAccounts();
        IEnumerable<Customer_VM> GetCustomers();
        void CreateAccount(Account_VM acc);
        void CreateCustomer(Customer_VM cs);
        void UpdateCustomer(Customer_VM cs);
    }
}
