using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("ATM")]
    public class ATM
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MachineId { get; set; }
        [Required]
        public required string Location { get; set; }
        [StringLength(100)]
        [Required]
        public required string Type { get; set; }
        [Required]
        public DateTime MaintenanceDate { get; set; }
        [Required]
        public bool IsEmpty { get; set; }
        [Required]
        public bool OutOfService { get; set; }

        [Required]
        public required int BranchId { get; set; }
        [Required]
        [ForeignKey("BranchId")]
        public required Branch Branch { get; set; }
    }
}
