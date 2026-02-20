using Microsoft.AspNetCore.Mvc;
using Musicstore.Models;

namespace Musicstore.Controllers;

public class Exercise03 : Controller
{
    // GET
    public IActionResult Index()
    {
        Book book1 = new Book("Guld Fuglen: Det næste liv",
            239.00,"Marie Louise Toksvig",
            "Grønningen",2013, "1297350" );
        book1.ImageUrl = "/Images/guldFuglen.webp";
        
        // List<string> songs = new List<string>
        // {
        //     "Stay Above",
        //     "Wish You Were Here (feat. Khalid)",
        //     "This Is Me Letting You Go",
        //     "Share That Love (feat. G-Eazy)",
        //     "Home Movies (feat. Mickey Guyton)",
        //     "All Of It All",
        //     "By The Way",
        //     "Lie",
        //     "Never Change",
        //     "Say Forever", 
        //     "One By One"
        // };
        List<Track> songs = new List<Track>
        {
            new Track("Stay Above", "2:29"),
            new Track("Wish You Were Here (feat. Khalid)", "2:55"),
            new Track("This Is Me Letting You Go", "2:50"),
            new Track("Share That Love (feat. G-Eazy)", "G-Eazy & Lukas Graham","2:52"),
            new Track("Home Movies (feat. Mickey Guyton)", "3:16"),
            new Track("All Of It All", "2:58"),
            new Track("By The Way", "2:49"),
            new Track("Lie", "2:59"),
            new Track("Never Change", "3:20"),
            new Track("Say Forever", "4:08"),
            new Track("One By One", "Lukas Graham", "3:04") 
        };
        MusicCD cd = new MusicCD("4(The Pink Album)", 159.95,"Lukas Graham","Universal Music", 2023, songs);
        cd.ImageUrl = "/Images/pinkAlbum.png";
        
        ViewBag.cd = cd;
        ViewBag.bog = book1;
        
        return View();
    }
}