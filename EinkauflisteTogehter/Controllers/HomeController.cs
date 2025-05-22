using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EinkauflisteTogehter.Models;

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
            return View("Angelegt");
        }
        return View();
    }
}