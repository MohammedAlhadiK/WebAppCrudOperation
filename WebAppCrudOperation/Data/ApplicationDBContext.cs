using Microsoft.EntityFrameworkCore;
using WebAppCrudOperation.Models;

namespace WebAppCrudOperation.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // دي طريقة تانية عشان التعامل مع الاسكيمة فى الداتا بيز 
            // attribute بدل طريقة ال
            // modelBuilder.Entity<Department>().ToTable("Departments", "HR");

        }
        public DbSet<Department>? Departments { get; set; } 
        public DbSet<Employee>? Employees { get; set; }
    }
}
