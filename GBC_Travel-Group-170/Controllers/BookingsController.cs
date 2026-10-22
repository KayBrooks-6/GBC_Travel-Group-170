using Microsoft.AspNetCore.Mvc;
using GBC_Travel_Group_170.Data;

namespace GBC_Travel_Group_170.Controllers;

public class BookingsController : Controller
{
    private readonly TravelDbContext _context;

    public BookingsController(TravelDbContext context)
    {
        _context = context;
    }

    // this checks to see if it is a flights or hotel booking by the fight or hotel id
    // and then passes it to the confirmation view 
    public IActionResult Confirmation(int id, string type = "flight")
    {
        var flight = _context.Flights.FirstOrDefault(f => f.Id == id);
        if (flight != null)
        {
            return View(flight);
        }

        var hotel = _context.Hotels.FirstOrDefault(h => h.Id == id);
        if (hotel != null)
        {
            return View(hotel);
        }

        return RedirectToAction("Index", "Home");
    }
}