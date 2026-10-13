using GBC_Travel_Group_170.Models;
using Microsoft.AspNetCore.Mvc;

namespace GBC_Travel_Group_170.Controllers;

public class FlightsController : Controller
{
    public IActionResult Index()
    {
        // made a few fake flight search results
        var sampleFlights = new List<Flight>
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

        return View(sampleFlights);
    }
}