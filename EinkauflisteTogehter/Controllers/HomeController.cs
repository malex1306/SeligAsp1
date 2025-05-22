using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EinkauflisteTogehter.Models;
using EinkauflisteTogehter.ViewModels;

namespace EinkauflisteTogehter.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ArtikelForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ArtikelForm(Position position)
    {
        if (ModelState.IsValid)
        {
            Repository.AddPosition(position);
            var vm = new AngelegtViewModel()
            {
                LastPosition = position,
                PositionAnzahl = Repository.Postions.Count()
            };
            return View("Angelegt", vm);
        }
        return View();
    }

    public IActionResult ArtikelAnsehen()
    {
        var liste = Repository.Postions
            .GroupBy(p => p.Geschaeft);
        return View(liste);
    }

    public IActionResult ArtikelLoeschen(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        Repository.RemovePosition((int) id);
        return RedirectToAction(nameof(ArtikelAnsehen));
    }
    public IActionResult AnzahlErhoehen(int id)
    {
        Repository.ErhoeheAnzahl(id);
        return RedirectToAction(nameof(ArtikelAnsehen));
    }

    public IActionResult AnzahlVerringern(int id)
    {
        Repository.VerringereAnzahl(id);
        return RedirectToAction(nameof(ArtikelAnsehen));
    }

}