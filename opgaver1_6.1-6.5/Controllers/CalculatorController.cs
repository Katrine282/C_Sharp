using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class CalculatorController : Controller
{
    // GET
    [HttpGet]
    public IActionResult TimeCalculator()
    {
        // return View("TimeCalculator");
        return View();
    }

    //POST
    [HttpPost]
    public IActionResult TimeCalculator(IFormCollection formCollection)
    {
        int hours = Convert.ToInt32(formCollection["Hours"]);
        int min = Convert.ToInt32(formCollection["Minutes"]);
        int sek = Convert.ToInt32(formCollection["Seconds"]);
        
        TimeSpan ts = new TimeSpan(0, hours, min, sek);
        double total = ts.TotalSeconds;
        
        ViewBag.Hours = hours;
        ViewBag.Minuts = min;
        ViewBag.Seconds = sek;
        ViewBag.Total = total;
        // return View("TimeCalculatorResult");
        return View();

    }
}