using Microsoft.AspNetCore.Mvc;

namespace Reciclajejuego.AppMVC.Controllers
{
    public class kevinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double num1, double num2, string operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "sumar":
                    resultado = num1 + num2;
                    break;

                case "restar":
                    resultado = num1 - num2;
                    break;

                case "multiplicar":
                    resultado = num1 * num2;
                    break;

                case "dividir":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        ViewBag.Error = "No se puede dividir entre 0";
                    break;
            }

            ViewBag.Resultado = resultado;

            return View();
        }
    }
}