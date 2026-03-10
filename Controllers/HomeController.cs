using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicamvcgit20260305.Models;
//hola
namespace practicamvcgit20260305.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
//hi
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
