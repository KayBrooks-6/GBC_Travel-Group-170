using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBC_Travel_Group_170.Models;

public class Flight
{
    [Required(ErrorMessage = "Airline name is required.")]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Flight number is required.")]
    [StringLength(20, ErrorMessage = "Flight number cannot exceed 20 characters.")]
    public string AirlineName { get; set; }
    public string FlightNumber { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    
    [Required(ErrorMessage = "Origin is required.")]
    [StringLength(100, ErrorMessage = "Origin cannot exceed 100 characters.")]
    public string Origin { get; set; }
    
    [Required(ErrorMessage = "Destination is required.")]
    [StringLength(100, ErrorMessage = "Destination cannot exceed 100 characters.")]
    public string Destination { get; set; }
    
    [Required]
    [Range(0.01, 10000.00, ErrorMessage = "Price must be between $0.01 and $10,000.00.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
}