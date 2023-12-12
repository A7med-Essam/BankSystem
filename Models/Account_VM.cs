using System.ComponentModel.DataAnnotations;

namespace BankSystem.Models
{
    public class Account_VM
    {
        //[StringLength(16, ErrorMessage = "Account Number must be 16 length")]
        [StringLength(16, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 16)]

        public required long AccountNumber { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public required float InterestRate { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public required bool IsClosed { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public required bool IsActive { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public required string Type { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public required double Balance { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public required string Holder { get; set; }
    }
}
