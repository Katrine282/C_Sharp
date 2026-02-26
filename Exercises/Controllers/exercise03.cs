using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exercise1.Controllers;

public class exercise03 : Controller
{
    // GET
    public IActionResult Index()
    {
        List<SelectListItem> breakfastItems = new List<SelectListItem>
        {
            new SelectListItem { Text = "Cornflakes", Value = "Cornflakes|45" },
            new SelectListItem { Text = "Egg", Value = "Egg|15" },
            new SelectListItem { Text = "Toast", Value = "Toast|10" },
            new SelectListItem { Text = "Juice", Value = "Juice|20" },
            new SelectListItem { Text = "Milk", Value = "Milk|10" },
            new SelectListItem { Text = "Coffee", Value = "Coffee|15" },
            new SelectListItem { Text = "Tea", Value = "Tea|10" }
        };

        ViewBag.BreakfastItems = breakfastItems;
        
        return View();
    }

    [HttpPost]
    public ActionResult Index(IFormCollection formData)
    {
        string name = formData["FullName"];
        string room = formData["RoomNumber"];
        string time = formData["Time"];

        var items = formData["menuitem"];

        ViewBag.Name = name;
        ViewBag.Room = room;
        ViewBag.Time = time;
        ViewBag.Items = items;

        return View("Receipt");
    }
    
}