using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(14)]
        [MinLength(14)]
        public long NationalId { get; set; }
        [StringLength(100)]
        [Required]
        public required string LastName { get; set; }
        [StringLength(100)]
        [Required]
        public required string FirstName { get; set; }
        [StringLength(100)]
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Address { get; set; }
        [StringLength(30)]
        [Required]
        public required string Phone { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public required virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<Complaint>? Complaint { get; set; }
    }
}
