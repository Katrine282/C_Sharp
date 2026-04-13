using Microsoft.AspNetCore.Mvc;
using DTO;
using BusinessLogic;

namespace GUI.Controllers;


public class HoldController : Controller
{
    // Liste af hold
    public IActionResult Index()
    {
        var hold = HoldLogik.GetAllHold();
        return View(hold);
    }

    // Opret hold
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(DTO.Hold h)
    {
        HoldLogik.AddHold(h);
        return RedirectToAction("Index");
    }

    // Se hold + studerende
    public IActionResult Details(int id)
    {
        var hold = HoldLogik.GetHoldById(id);
        ViewBag.Studerende = HoldLogik.GetStudereneTilHold(id);
        return View(hold);
    }

    // Tilføj studerende til hold
    public IActionResult AddStuderende(int holdId)
    {
        ViewBag.HoldId = holdId;
        ViewBag.Studerende = StuderendeLogik.GetAllStuderende();
        return View();
    }

    [HttpPost]
    public IActionResult AddStuderende(int holdId, int studId)
    {
        HoldLogik.AddStuderendeTilHold(holdId, studId);
        return RedirectToAction("Details", new { id = holdId });
    }
    
    [HttpPost]
    public IActionResult GivKarakter(int holdId)
    {
        HoldLogik.GivKarakterTilHold(holdId);
    
        return RedirectToAction("Details", new { id = holdId });
    }
}