using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
        [Required]
        public required string Description { get; set; }
        public double Amount { get; set; }
        [Required]
        [StringLength(50)]
        public required string Type { get; set; }
        [Required]
        public required long AccountNumber { get; set; }
        [ForeignKey("AccountNumber")]
        [Required]
        public required Account Account { get; set; }
        public required long NationalId { get; set; }
        [ForeignKey("NationalId")]
        [Required]
        public required Employee Employee { get; set; }
    }
}
