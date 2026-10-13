using GBC_Travel_Group_170.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBC_Travel_Group_170.Controllers;

public class HotelsController : Controller
{
    private readonly List<Hotel> _hotels = new()
    {
        new Hotel
        {
            Id = 1,
            Name = "Harbourfront",
            StarRating = 3,
            Address = "Toronto, ON - 235 Queens Quay W",
            PricePerNight = 189.00m,
            RoomsAvailable = 12,
            Amenities = new List<string> { "Free Wi-Fi", "Pool" },
            Description = "Free tacos every Tuesday at 4 a.m."
        },
        new Hotel
        {
            Id = 2,
            Name = "Downtown Suites",
            StarRating = 4,
            Address = "Toronto, ON - 100 Yonge St",
            PricePerNight = 245.00m,
            RoomsAvailable = 8,
            Amenities = new List<string> { "Free Wi-Fi", "Gym", "Breakfast" },
            Description = "Right in the heart of the city with luxury amenities."
        }
    };
    
    public IActionResult Index() 
    {
        return View(_hotels);
    }
    
    public IActionResult Details(int id)
    {
        var hotel = _hotels.FirstOrDefault(h => h.Id == id) ?? _hotels.First();
        return View(hotel);
    }
}