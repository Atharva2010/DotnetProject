namespace EmployeeMVCORM.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("EmployeeData2")]
public class Employee{

    [Key]
    public int Id{get;set;}
    [NotNull]
    public string Name{get;set;}
    [NotNull]
    public double Salary{get;set;}
    // [NotNull]
    // [EnumDataType(typeof(Dept))]
    // public Object Department{get;set;}

    public override string ToString()
    {
        return Id + Name + Salary;
    }
}