using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using containers_101.Models;
using containers_101.DataModel;
using Microsoft.EntityFrameworkCore;

namespace containers_101.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Containers101Context _dbContext;

    public HomeController(
        ILogger<HomeController> logger,
        Containers101Context dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index()
    {
        var employees = await _dbContext.Employees.ToListAsync();

        return View(employees);
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
