using Microsoft.AspNetCore.Mvc;

namespace practicamvcgit20260305.Controllers
{
    public class DanielaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(double n1, double n2, string operacion)
        
        {
            double resultado = 0;

            switch (operacion)
            {
                case "+": resultado = n1 + n2; break;
                case "-": resultado = n1 - n2; break;
                case "*": resultado = n1 * n2; break;
                case "/": resultado = n2 != 0 ? n1 / n2 : 0; break;
            }

            ViewBag.Resultado = resultado;
            return View("Index");
        }
   public IActionResult Limpiar()
        {
            return RedirectToAction("Index");
        }
    }
}