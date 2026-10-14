namespace GBC_Travel_Group_170.Data;

using Microsoft.EntityFrameworkCore;
using GBC_Travel_Group_170.Models;

public class TravelDbContext : DbContext
{
    public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options) { }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Flight> Flights { get; set; }
}