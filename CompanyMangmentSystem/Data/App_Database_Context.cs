using CompanyMangmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyMangmentSystem.Data
{
    public class App_Database_Context:DbContext
    {
        public App_Database_Context(DbContextOptions<App_Database_Context> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Department)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Project>()
                .HasOne(x => x.Department)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(x => x.Project)
                .WithMany(x => x.EmployeeProjects)
                .HasForeignKey(x => x.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(x => x.Employee)
                .WithMany(x => x.EmployeeProjects)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
