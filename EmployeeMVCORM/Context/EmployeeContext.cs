namespace EmployeeMVCORM.Context;

using EmployeeMVCORM.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
public class EmployeeContext:DbContext
{
    public DbSet<Employee> Employees {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string con=@"server=localhost;port=3306;user=root;password=root;database=root";
        optionsBuilder.UseMySQL(con);
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    //     modelBuilder.Entity<Employee>(entity =>
    //     {
    //         entity.HasKey(e => e.Id);
    //         entity.Property(e => e.Name).IsRequired();
    //         entity.Property(e => e.Department).IsRequired();
    //         entity.Property(e => e.Salary).IsRequired();
    //     });
    // }

}