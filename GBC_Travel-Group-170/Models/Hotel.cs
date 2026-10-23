using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBC_Travel_Group_170.Models;

public class Hotel
{
    public int Id { get; set; } 
    
    [Required(ErrorMessage = "Hotel name is required.")]
    [StringLength(150, ErrorMessage = "Hotel name cannot exceed 150 characters.")]
    
    public string Name { get; set; }
    public int StarRating { get; set; }
    
    [Required(ErrorMessage = "Address is required.")]
    [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
    public string Address { get; set; }
    
    [Range(0.01, 20000.00, ErrorMessage = "Price per night must be between $0.01 and $20,000.00.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal PricePerNight { get; set; }
    
    [Range(0, 1000, ErrorMessage = "Rooms available must be a non-negative number.")]
    public int RoomsAvailable { get; set; }
    
    public List<string> Amenities { get; set; }
    
    [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
    public string Description { get; set; }
    
    [StringLength(500)]
    public string ImageUrl { get; set; }
}