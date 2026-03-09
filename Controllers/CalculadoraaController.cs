using Microsoft.AspNetCore.Mvc;
namespace Calc.Controllers
{
    public class CalculadoraController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double numero1, double numero2, string operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "suma":
                    resultado = numero1 + numero2;
                    break;

                case "resta":
                    resultado = numero1 - numero2;
                    break;

                case "multiplicacion":
                    resultado = numero1 * numero2;
                    break;

                case "division":
                    if (numero2 != 0)
                        resultado = numero1 / numero2;
                    else
                        ViewBag.Error = "No se puede dividir entre 0";
                    break;
            }

            ViewBag.Resultado = resultado;
            return View();
        }
    }
} 