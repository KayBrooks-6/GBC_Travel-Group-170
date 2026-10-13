using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GBC_Travel_Group_170.Models;
using GBC_Travel_Group_170.Data;

namespace GBC_Travel_Group_170.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(DataStore.Hotels);
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