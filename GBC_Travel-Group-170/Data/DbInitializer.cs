using GBC_Travel_Group_170.Models;

namespace GBC_Travel_Group_170.Data;

public static class DbInitializer
{
    public static void Initialize(TravelDbContext context)
    {
        // check if data already exists as this is the for seeding the database
        if (context.Hotels.Any() && context.Flights.Any())
        {
            return;
        }
        
        var hotels = new Hotel[]
        {
            new Hotel { Name = "Harbourfront", StarRating = 3, Address = "Toronto, ON - 235 Queens Quay W", PricePerNight = 189.00m, RoomsAvailable = 12, Amenities = new List<string> { "Free Wi-Fi", "Pool" }, Description = "Free tacos every Tuesday at 4 a.m." },
            new Hotel { Name = "Downtown Suites", StarRating = 4, Address = "Toronto, ON - 100 Yonge St", PricePerNight = 245.00m, RoomsAvailable = 8, Amenities = new List<string> { "Free Wi-Fi", "Gym", "Breakfast" }, Description = "Right in the heart of the city with luxury amenities." },
            new Hotel { Name = "Grand Vista", StarRating = 5, Address = "Vancouver, BC - 1100 Burrard St", PricePerNight = 320.00m, RoomsAvailable = 5, Amenities = new List<string> { "Spa", "Valet", "Pool" }, Description = "Stunning mountain views and top-tier service." },
            new Hotel { Name = "Pacific Inn", StarRating = 3, Address = "Victoria, BC - 700 Government St", PricePerNight = 150.00m, RoomsAvailable = 15, Amenities = new List<string> { "Free Wi-Fi", "Parking" }, Description = "Charming historic stay near the inner harbor." },
            new Hotel { Name = "Metro Lodge", StarRating = 2, Address = "Montreal, QC - 1250 Peel St", PricePerNight = 110.00m, RoomsAvailable = 20, Amenities = new List<string> { "Free Wi-Fi" }, Description = "Affordable and clean accommodations downtown." }
        };
        context.Hotels.AddRange(hotels);
        
        var flights = new Flight[]
        {
            new Flight { AirlineName = "Air Canada", FlightNumber = "AC101", Origin = "Toronto (YYZ)", Destination = "Vancouver (YVR)", DepartureTime = DateTime.Now.AddDays(1).Date.AddHours(8), ArrivalTime = DateTime.Now.AddDays(1).Date.AddHours(11), Price = 345.00m },
            new Flight { AirlineName = "WestJet", FlightNumber = "WJ452", Origin = "Toronto (YYZ)", Destination = "Calgary (YYC)", DepartureTime = DateTime.Now.AddDays(2).Date.AddHours(9), ArrivalTime = DateTime.Now.AddDays(2).Date.AddHours(12), Price = 280.50m },
            new Flight { AirlineName = "Porter", FlightNumber = "PD305", Origin = "Toronto (YTZ)", Destination = "Montreal (YUL)", DepartureTime = DateTime.Now.AddDays(1).Date.AddHours(14), ArrivalTime = DateTime.Now.AddDays(1).Date.AddHours(15), Price = 175.00m },
            new Flight { AirlineName = "Air Canada", FlightNumber = "AC884", Origin = "Vancouver (YVR)", Destination = "Calgary (YYC)", DepartureTime = DateTime.Now.AddDays(3).Date.AddHours(6), ArrivalTime = DateTime.Now.AddDays(3).Date.AddHours(7), Price = 195.00m },
            new Flight { AirlineName = "WestJet", FlightNumber = "WJ712", Origin = "Montreal (YUL)", Destination = "Vancouver (YVR)", DepartureTime = DateTime.Now.AddDays(4).Date.AddHours(10), ArrivalTime = DateTime.Now.AddDays(4).Date.AddHours(15), Price = 420.00m }
        };
        context.Flights.AddRange(flights);

        context.SaveChanges();
    }
}