using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("Account")]
    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(16)]
        [MinLength(16)]
        public required long AccountNumber { get; set; }
        [Required]
        public required float InterestRate { get; set; }
        [Required]
        public required bool IsClosed { get; set; }
        [Required]
        public required bool IsActive { get; set; }
        [Required]
        [StringLength(100)]
        public required string Type { get; set; }
        [Required]
        public required double Balance { get; set; }
        [Required]
        [StringLength(100)]
        public required string Holder { get; set; }
        [Required]
        public required long NationalId { get; set; }
        [Required]
        [ForeignKey("NationalId")]
        public required Customer Customer { get; set; }
        public virtual ICollection<Loan>? Loan { get; set; }
        [Required]
        public required virtual ICollection<Transaction> Transaction { get; set; }
        public virtual ICollection<PaymentCard>? PaymentCard { get; set; }
    }
}
