using Microsoft.AspNetCore.Mvc;
using DTO;
using BusinessLogic;

namespace GUI.Controllers;


public class HoldController : Controller
{
    // Liste af hold
    public IActionResult Index()
    {
        var hold = StuderendeLogik.GetAllHold();
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
        StuderendeLogik.AddHold(h);
        return RedirectToAction("Index");
    }

    // Se hold + studerende
    public IActionResult Details(int id)
    {
        var hold = StuderendeLogik.GetHoldById(id);
        ViewBag.Studerende = StuderendeLogik.GetStudereneTilHold(id);
        return View(hold);
    }

    // Tilføj studerende til hold
    public IActionResult AddStuderende(int id)
    {
        ViewBag.HoldId = id;
        ViewBag.Studerende = StuderendeLogik.GetAllStuderende();
        return View();
    }

    [HttpPost]
    public IActionResult AddStuderende(int holdId, int studId)
    {
        StuderendeLogik.AddStuderendeTilHold(holdId, studId);
        return RedirectToAction("Details", new { id = holdId });
    }
}