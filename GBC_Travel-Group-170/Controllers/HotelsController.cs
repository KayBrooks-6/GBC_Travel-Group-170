using GBC_Travel_Group_170.Models;
using Microsoft.AspNetCore.Mvc;
using GBC_Travel_Group_170.Data;

namespace GBC_Travel_Group_170.Controllers;

public class HotelsController : Controller
{
    
    public IActionResult Index() 
    {
        return View(DataStore.Hotels);
    }
    
    public IActionResult Details(int id)
    {
        var hotel = DataStore.Hotels.FirstOrDefault(h => h.Id == id) ?? DataStore.Hotels.First();
        return View(hotel);
    }
}