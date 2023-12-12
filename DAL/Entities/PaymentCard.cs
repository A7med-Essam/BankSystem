using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("PaymentCard")]
    public class PaymentCard
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CardNumber { get; set; }
        [Required]
        public DateTime ExpireAt { get; set; }
        [Required]
        public DateTime InitiatedIn { get; set; }
        [Required]
        public required string Type { get; set; }
        public float CardFees { get; set; }
        public bool isActive { get; set; }
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
