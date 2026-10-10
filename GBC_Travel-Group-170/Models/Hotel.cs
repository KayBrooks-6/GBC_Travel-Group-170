namespace GBC_Travel_Group_170.Models;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int StarRating { get; set; }
    public string Address { get; set; }
    public decimal PricePerNight { get; set; }
    public int RoomsAvailable { get; set; }
    public List<string> Amenities { get; set; }
    public string Description { get; set; }
}