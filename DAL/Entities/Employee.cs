using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystem.DAL.Entities
{
    [Table("Employee")]
    public class Employee
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

        public float Bonus { get; set; }
        public float Raise { get; set; }
        public byte OvertimeHours { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        [StringLength(50)]
        public required string Position { get; set; }
        public float Deduction { get; set; }
        public float SocialInsuranceRate { get; set; }
        public float HealthInsuranceRate { get; set; }
        public double Salary { get; set; }
        //public int? ManagerId { get; set; }
        //[ForeignKey("ManagerId")]
        //[Required]
        //public required Employee Manager { get; set; }

        [Required]
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        [Required]
        public required Branch Branch { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        [Required]
        public required Department Department { get; set; }
        [Required]
        public required virtual ICollection<Loan> Loan { get; set; }
        public virtual ICollection<Transaction>? Transaction { get; set; }
        [Required]
        public required virtual ICollection<PaymentCard> PaymentCard { get; set; }

    }
}
