using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCrudOperation.Models
{
    [Table("Departments",Schema ="HR")]
    public class Department
    {
        [Key]
        [Display(Name ="ID")]
        public int DepartmentID { get; set; }
        [Display(Name="Department Name")]
        [Column(TypeName="varchar(200)")]
        public string DepartmentName { get; set; } = string.Empty;

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

    }
}
