using GBC_Travel_Group_170.Data;
using GBC_Travel_Group_170.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GBC_Travel_Group_170.Controllers;

public class FlightsController : Controller
{
    private readonly TravelDbContext _context;

    public FlightsController(TravelDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(string from, string to, DateTime? date, int? passengers)
    {
        var query = _context.Flights.AsQueryable();

        if (!string.IsNullOrWhiteSpace(from))
        {
            query = query.Where(f => EF.Functions.ILike(f.Origin, $"%{from}%"));
        }
        
        if (!string.IsNullOrWhiteSpace(to))
        {
            query = query.Where(f => EF.Functions.ILike(f.Destination, $"%{to}%"));
        }
        
        if (date.HasValue)
        {
            var searchDate = DateTime.SpecifyKind(date.Value.Date, DateTimeKind.Utc);
            query = query.Where(f => f.DepartureTime.Date == searchDate);
        }
        return View(query.ToList());
    }

    public IActionResult Details(int id)
    {
        var flight = _context.Flights.FirstOrDefault(f => f.Id == id) ?? _context.Flights.First();
        return View(flight);
    }
}