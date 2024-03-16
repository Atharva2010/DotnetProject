using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeMVCORM.Models;
using EmployeeMVCORM.Services;

namespace EmployeeMVCORM.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private EmployeeServices obj=new EmployeeServices();
    public HomeController(ILogger<HomeController> logger)
    {
        Console.WriteLine("Inside Home Con");
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
