using BankSystem.BL.Interface;
using BankSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace BankSystem.BL.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthRepository(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task Login(Login_VM model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var Results = await _signInManager.PasswordSignInAsync(user, model.password, model.RememberMe, false);
                if (!Results.Succeeded)
                {
                    throw new Exception("Invalid credentials");
                }
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        public async Task Register(Register_VM model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                throw new Exception("User Exist");
            }
            else
            {
                var newUser = new IdentityUser { Email = model.Email, UserName = model.UserName };
                var Results = await _userManager.CreateAsync(newUser, model.Password);
                if (!Results.Succeeded)
                {
                    var errorMessage = "";
                    foreach (var error in Results.Errors)
                    {
                        errorMessage += error.Description + " ";
                    }
                    throw new Exception(errorMessage);
                }
            }
        }

        public async Task SignOut() => await _signInManager.SignOutAsync();
    }
}
