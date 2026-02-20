using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class RockbandsController : Controller
{
    // GET
    public IActionResult Index()
    {
        string[] bands = new string[]
        {
            "Led Zeppelin", "The Beatles",
            "Pink Floyd", "The Jimi Hendrix Experience",
            "Van Halen", "Queen", "The Eagles", "Metallica",
            "U2", "Bob Marley and the Wailers"
        }; 
        ViewBag.bands = bands;
        
        return View();
    }
}