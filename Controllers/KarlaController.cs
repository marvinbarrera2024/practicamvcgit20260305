 using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicamvcgit20260305.Models;

namespace practicamvcgit20260305.Controllers;

public class Karla Contoller: Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]


    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
