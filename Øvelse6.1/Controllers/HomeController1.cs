using Microsoft.AspNetCore.Mvc;

namespace Øvelse6._1.Controllers;

public class HomeController1 : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}