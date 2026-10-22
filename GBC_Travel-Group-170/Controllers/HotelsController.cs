using GBC_Travel_Group_170.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GBC_Travel_Group_170.Controllers;

public class HotelsController : Controller
{
    private readonly TravelDbContext _context;

    public HotelsController(TravelDbContext context)
    {
        _context = context;
    }
    public IActionResult Index(string destination, DateTime? checkin, DateTime? checkout)
    {
        var query = _context.Hotels.AsQueryable();
        if(!string.IsNullOrEmpty(destination))
        {
            query = query.Where(h => EF.Functions.ILike(h.Name, $"%{destination}%") || EF.Functions.ILike(h.Address, $"%{destination}%"));
        }

        return View(query.ToList());
    }

    public IActionResult Details(int id)
    {
        var hotel = _context.Hotels.FirstOrDefault(h => h.Id == id) ?? _context.Hotels.First();
        return View(hotel);
    }
}