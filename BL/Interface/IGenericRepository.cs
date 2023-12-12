namespace BankSystem.BL.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Create(T model);
        void Update(T model);
    }
}
