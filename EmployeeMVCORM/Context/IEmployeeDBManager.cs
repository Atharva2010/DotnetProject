using EmployeeMVCORM.Entity;

namespace EmployeeMVCORM.Context;

public interface IEmployeeDBManager{

    public List<Employee> GetAll();
    public Employee GetById(int id);
    public void UpdateEmployee(Employee e);
    public void DeleteEmployee(int id);
    public void AddEmployee(Employee e);
}