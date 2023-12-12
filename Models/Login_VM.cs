using System.ComponentModel.DataAnnotations;

namespace BankSystem.Models
{
    public class Login_VM
    {
        [EmailAddress(ErrorMessage = "Email Not Valid")]
        public required string Email { get; set; }

        [DataType(DataType.Password)]
        public required string password { get; set; }
        public required bool RememberMe { get; set; }
    }
}
