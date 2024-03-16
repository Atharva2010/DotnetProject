using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeMVCORM.Models;
using EmployeeMVCORM.Services;
using EmployeeMVCORM.Entity;

namespace EmployeeMVCORM.Controllers;

public class EmployeeController : Controller
{
    // private EmployeeServices obj=new EmployeeServices();
    private readonly IEmployeeServices _svc;
    public EmployeeController(IEmployeeServices svc)
    {
        Console.WriteLine("In EmployeeController Constructor");
        _svc=svc;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult AddEmp()
    {
        return View();

    }

    [HttpPost]
    public IActionResult AddEmp(Employee e)
    {

        Console.WriteLine(e);
        // e.Department=Dept.DEV;
        _svc.AddEmployee(e);
        return RedirectToAction("Index");

    }

    [HttpGet]
    public IActionResult GetAllEmp()
    {
        List<Employee> list=_svc.GetAll();
        return View(list);
    }

    public IActionResult DeleteEmp(int id)
    {
        _svc.DeleteEmployee(id);
        return RedirectToAction("GetAllEmp");
    }

    [HttpGet]
    public IActionResult UpdateEmp(int id)
    {
        Employee e=_svc.GetById(id);
        return View(e);
    }

    [HttpPost]
    public IActionResult UpdateEmp(Employee e)
    {
        _svc.UpdateEmployee(e);
        return RedirectToAction("GetAllEmp");
    }
}