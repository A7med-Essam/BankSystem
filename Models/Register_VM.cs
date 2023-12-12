using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BankSystem.Models
{
    public class Register_VM
    {
        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage = "email not valid")]
        [DisplayName("email")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "password is required")]
        [DisplayName("password")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [Required(ErrorMessage = "username is required")]
        [DisplayName("username")]
        public required string UserName { get; set; }
    }
}
