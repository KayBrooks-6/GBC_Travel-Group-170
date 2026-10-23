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

    public IActionResult Index(string from, string to, DateTime? date, int? passengers, decimal? minPrice, decimal? maxPrice, string[] airline, string sortOrder)
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
        
        if (minPrice.HasValue)
        {
            query = query.Where(f => f.Price >= minPrice.Value);
        }
        if (maxPrice.HasValue)
        {
            query = query.Where(f => f.Price <= maxPrice.Value);
        }
        
        if (airline != null && airline.Length > 0)
        {
            query = query.Where(f => airline.Contains(f.AirlineName));
        }
        
        query = sortOrder switch
        {
            "price_high" => query.OrderByDescending(f => f.Price),
            _ => query.OrderBy(f => f.Price),
        };
        
        ViewBag.From = from;
        ViewBag.To = to;
        ViewBag.Date = date?.ToString("yyyy-MM-dd");
        ViewBag.MinPrice = minPrice;
        ViewBag.MaxPrice = maxPrice;
        ViewBag.SelectedAirlines = airline ?? Array.Empty<string>();
        ViewBag.SortOrder = sortOrder;
        
        return View(query.ToList());
    }

    public IActionResult Details(int id)
    {
        var flight = _context.Flights.FirstOrDefault(f => f.Id == id) ?? _context.Flights.First();
        return View(flight);
    }
}