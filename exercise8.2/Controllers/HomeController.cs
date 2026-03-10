using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using exercise8._2.Models;

namespace exercise8._2.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult VisAlle()
    {
        List<Person> personer = AllePersoner();
        return View(personer);
    }

    
    public IActionResult VisEn()
    {
        List<Person> personer = AllePersoner();
        return View(personer.First());
    }
    private List<Person> AllePersoner()
    {
        return new List<Person>
        {
            new Person("Peter", "Hansen"),
            new Person("Maria", "Jensen"),
            new Person("Lars", "Andersen"),
            new Person("Sofie", "Madsen"),
            new Person("Thomas", "Nielsen"),
            new Person("Emma", "Pedersen"),
            new Person("Jonas", "Christensen"),
            new Person("Freja", "Larsen")
        };
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}