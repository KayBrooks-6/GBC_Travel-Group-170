using GBC_Travel_Group_170.Data;
using GBC_Travel_Group_170.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBC_Travel_Group_170.Controllers;

public class FlightsController : Controller
{
    private readonly TravelDbContext _context;

    public FlightsController(TravelDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Flights.ToList());
    }

    public IActionResult Details(int id)
    {
        var flight = _context.Flights.FirstOrDefault(f => f.Id == id) ?? _context.Flights.First();
        return View(flight);
    }
}