using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("Complaint")]
    public class Complaint
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Description { get; set; }
        [Required]
        public required long NationalId { get; set; }
        [Required]
        [ForeignKey("NationalId")]
        public required Customer Customer { get; set; }
    }
}
