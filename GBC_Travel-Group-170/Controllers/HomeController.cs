using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GBC_Travel_Group_170.Models;

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
        return View();
    }
    
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Flights()
    {
        return View();
    }
    public IActionResult Hotels()
    {
        return View();
    }

    public IActionResult Details(int id)
    {
        // fake hotel listing
        var sampleHotel = new Hotel
        {
            Id = id,
            Name = "Harbourfront",
            StarRating = 3,
            Address = "Toronto, ON - 235 Queens Quay W",
            PricePerNight = 189.00m,
            RoomsAvailable = 12,
            Amenities = new List<string> { "Free Wi-Fi", "Pool" },
            Description = "Free tacos every Tuesday at 4 a:m"
        };

        return View(sampleHotel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}