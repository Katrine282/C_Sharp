using System.Diagnostics;
using DTO;
using Microsoft.AspNetCore.Mvc;
using GUI.Models;
using BusinessLogic;

namespace GUI.Controllers;

public class StuderendeController : Controller
{
    // GET: Alle
    public IActionResult Index()
    {
        List<Studerende> liste = StuderendeLogik.GetAllStuderende();
        return View(liste);
    }

    // GET: En enkelt (via id)
    public IActionResult Details(int id)
    {
        var studerende = StuderendeLogik.GetStuderende(id);
        return View(studerende);
    }

    // GET: Opret
    public IActionResult Create()
    {
        return View();
    }

    // POST: Opret
    [HttpPost]
    public IActionResult Create(DTO.Studerende s)
    {
        StuderendeLogik.AddStuderende(s);
        return RedirectToAction("Index");
    }

    // // GET: Edit
    // public IActionResult Edit(int id)
    // {
    //     var studerende = getStuderende(id);
    //     return View(studerende);
    // }
    //
    // // POST: Edit
    // [HttpPost]
    // public IActionResult Edit(DTO.Studerende s)
    // {
    //     updateStuderende(s);
    //     return RedirectToAction("Index");
    // }

    // GET: Delete
    public IActionResult Delete(int id)
    {
        var studerende = StuderendeLogik.GetStuderende(id);
        return View(studerende);
    }

    // POST: Delete
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int holdId)
    {
        StuderendeLogik.DeleteStuderende(holdId);
        return RedirectToAction("Index");
    }
}