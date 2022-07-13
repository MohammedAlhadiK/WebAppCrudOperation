using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCrudOperation.Models
{
    [Table("Employees", Schema = "HR")]
    public class Employee
    {
        [Key]
        [Display(Name = "ID")]
        public int EmployeeId { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Employee Image")]
        [Column(TypeName = "varchar(250)")]
        public string? EmployeeImage { get; set; } = string.Empty;
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        [Display(Name = "Salary")]
        public decimal Salary { get; set; }
        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd-MMMM-yyyy}")]
        public DateTime? HiringDate { get; set; }
        [Required]
        [Display(Name = "National ID")]
        [MaxLength(length: 14)]
        [MinLength(length: 14)]
        [Column(TypeName = "varchar(14)")]
        public string NationalityID { get; set; } = string.Empty;

        // Creating relation between Department and Employee
        public int DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        
        public Department? Department { get; set; }
        
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        //End Relation
    }
}
