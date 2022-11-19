using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Gamf1.Models;
using Gamf1.Data;

namespace Gamf1.Controllers;

public class HomeController : Controller
{
    private readonly GAMFDbContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, GAMFDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var students = _context.Students.ToList();


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

