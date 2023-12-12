using BankSystem.Models;

namespace BankSystem.BL.Interface
{
    public interface IAuthRepository
    {
        Task Login(Login_VM model);
        Task Register(Register_VM model);
        Task SignOut();
    }
}
