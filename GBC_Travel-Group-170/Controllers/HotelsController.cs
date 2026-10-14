using GBC_Travel_Group_170.Data;
using Microsoft.AspNetCore.Mvc;

namespace GBC_Travel_Group_170.Controllers;

public class HotelsController : Controller
{
    private readonly TravelDbContext _context;

    public HotelsController(TravelDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Hotels.ToList());
    }

    public IActionResult Details(int id)
    {
        var hotel = _context.Hotels.FirstOrDefault(h => h.Id == id) ?? _context.Hotels.First();
        return View(hotel);
    }
}