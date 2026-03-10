using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class OscarRestaController : Controller
    {
        // Muestra la vista
        public IActionResult Index()
        {
            return View();
        }

        // Método para realizar la resta
        [HttpPost]
        public IActionResult Index(int num1, int num2)
        {
            int resultado = num1 - num2;
            ViewBag.Resultado = resultado;

            return View();
        }
    }
}
