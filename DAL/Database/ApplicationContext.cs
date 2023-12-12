using BankSystem.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.DAL.Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> db) : base(db)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<ATM> ATMs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<PaymentCard> PaymentCards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
