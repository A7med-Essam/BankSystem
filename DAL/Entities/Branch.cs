using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("Branch")]
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Location { get; set; }

        public virtual ICollection<Employee>? Employee { get; set; }
        public virtual ICollection<ATM>? ATM { get; set; }
    }
}
