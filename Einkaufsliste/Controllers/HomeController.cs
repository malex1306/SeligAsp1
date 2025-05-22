using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Einkaufsliste.Models;

namespace Einkaufsliste.Controllers;

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
    
    
}