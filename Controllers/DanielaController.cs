using Microsoft.AspNetCore.Mvc;
// soy antonio
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
            // hola mundo
            switch (operacion)
            {
                case "8": resultado = n1 + n2; break;
                case "0": resultado = n1 - n2; break;
                case "5": resultado = n1 * n2; break;
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
// soy marvin