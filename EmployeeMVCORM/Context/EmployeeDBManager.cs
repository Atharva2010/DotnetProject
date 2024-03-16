using EmployeeMVCORM.Entity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMVCORM.Context;

public class EmployeeDBManager : IEmployeeDBManager
{
    public EmployeeDBManager(){

        Console.WriteLine("In EmployeeDBManager Constructor");
        using(var context=new EmployeeContext())
        {
            context.Database.CreateExecutionStrategy();
            context.Database.EnsureCreated();
            context.Employees.CreateDbCommand();

        }
    }

    public void AddEmployee(Employee e)
    {
        using(var context=new EmployeeContext())
        {
            context.Employees.CreateDbCommand();
            context.Employees.Add(e);
            context.SaveChanges();
        }
        //throw new NotImplementedException();
    }

    public void DeleteEmployee(int id)
    {
        using(var con=new EmployeeContext())
        {
            var tx=con.Employees.Remove(con.Employees.Find(id));
            con.SaveChanges();
            Console.WriteLine(tx);
        }
        //throw new NotImplementedException();
    }

    public List<Employee> GetAll()
    {
        
        using(var con=new EmployeeContext())
        {
            var Employee =from emp in con.Employees select emp;
            return Employee.ToList<Employee>();
        }
        //throw new NotImplementedException();
    }

    public Employee GetById(int id)
    {
        using(var con=new EmployeeContext())
        {
            var Emp=con.Employees.Find(id);
            return Emp;
        }
        //throw new NotImplementedException();
    }

    public void UpdateEmployee(Employee e)
    {
        using(var con=new EmployeeContext())
        {
            con.Employees.Update(e);
            con.SaveChanges();
        }
        //throw new NotImplementedException();
    }
}