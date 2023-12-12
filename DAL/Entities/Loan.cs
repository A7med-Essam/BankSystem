using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("Loan")]
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        public float InterestRate { get; set; }
        public bool isApproved { get; set; }
        public DateTime LoanStartDate { get; set; }
        public DateTime Duration { get; set; }
        public int Amount { get; set; }
        [Required]
        public required long AccountNumber { get; set; }
        [ForeignKey("AccountNumber")]
        [Required]
        public required Account Account { get; set; }

        [Required]
        public required long NationalId { get; set; }
        [ForeignKey("NationalId")]
        [Required]
        public required Employee Employee { get; set; }
    }
}
