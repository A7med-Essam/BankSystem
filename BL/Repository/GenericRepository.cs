using BankSystem.BL.Interface;
using BankSystem.DAL.Database;

namespace BankSystem.BL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext _context;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();
        public T Create(T model)
        {
            _context.Set<T>().Add(model);
            _context.SaveChanges();
            return model;
        }
        public void Update(T model)
        {
            _context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
