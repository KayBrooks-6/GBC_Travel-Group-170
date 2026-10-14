using System.Diagnostics;
using GBC_Travel_Group_170.Data;
using GBC_Travel_Group_170.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBC_Travel_Group_170.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly TravelDbContext _context;

    public HomeController(ILogger<HomeController> logger,  TravelDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Hotels.ToList());
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Flights()
    {
        return View("/Views/Flights/Index.cshtml");
    }

    public IActionResult Hotels()
    {
        return View("/Views/Hotels/Index.cshtml");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}