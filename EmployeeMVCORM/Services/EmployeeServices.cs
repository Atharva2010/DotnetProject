using EmployeeMVCORM.Context;
using EmployeeMVCORM.Entity;

namespace EmployeeMVCORM.Services;

public class EmployeeServices : IEmployeeServices
{

    private EmployeeDBManager obj=new EmployeeDBManager();

    public void AddEmployee(Employee e)
    {
        obj.AddEmployee(e);
        //throw new NotImplementedException();
    }

    public void DeleteEmployee(int id)
    {
        obj.DeleteEmployee(id);
        //throw new NotImplementedException();
    }

    public List<Employee> GetAll()
    {
        return obj.GetAll();
        //throw new NotImplementedException();
    }

    public Employee GetById(int id)
    {
        return obj.GetById(id);
        //throw new NotImplementedException();
    }

    public void UpdateEmployee(Employee e)
    {
        obj.UpdateEmployee(e);
        //throw new NotImplementedException();
    }
}