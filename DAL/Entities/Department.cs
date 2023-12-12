using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Required]
        public required virtual ICollection<Employee> Employee { get; set; }
    }
}
