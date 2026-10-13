using GBC_Travel_Group_170.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBC_Travel_Group_170.Controllers;

public class FlightsController : Controller
{
    private readonly List<Flight> _flights = new()
    {
        new Flight
        {
            Id = 1,
            AirlineName = "Air Canada",
            FlightNumber = "AC101",
            DepartureTime = new DateTime(2026, 6, 1, 8, 0, 0),
            ArrivalTime = new DateTime(2026, 6, 1, 11, 30, 0),
            Origin = "YYZ",
            Destination = "YVR",
            Price = 350.00m
        },
        new Flight
        {
            Id = 2,
            AirlineName = "WestJet",
            FlightNumber = "WJ405",
            DepartureTime = new DateTime(2026, 6, 1, 12, 15, 0),
            ArrivalTime = new DateTime(2026, 6, 1, 15, 45, 0),
            Origin = "YYZ",
            Destination = "YVR",
            Price = 295.50m
        }
    };

    public IActionResult Index()
    {
        return View(_flights);
    }

    public IActionResult Details(int id)
    {
        var flight = _flights.FirstOrDefault(f => f.Id == id) ?? _flights.First();
        return View(flight);
    }
}