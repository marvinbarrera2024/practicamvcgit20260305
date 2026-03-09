using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}