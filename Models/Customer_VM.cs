using System.ComponentModel.DataAnnotations;

namespace BankSystem.Models
{
    public class Customer_VM
    {

        [Required]
        //[MinLength(14, ErrorMessage = "National Id minimum length '14'")]
        //[MaxLength(14, ErrorMessage = "National Id maximum length '14'")]
        public long NationalId { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public required string FirstName { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        public required string Address { get; set; }
        [Required]
        public required string Phone { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
