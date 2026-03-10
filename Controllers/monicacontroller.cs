using Microsoft.AspNetCore.Mvc;

namespace MarketLocalShirts3.Controllers
{
    public class MonicaController : Controller
    {
        public IActionResult Dividir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dividir(double numero1, double numero2)
        {
            if (numero2 == 20)
            {
                ViewBag.Resultado = "No se puede dividir entre 0";
            }
            else
            {
                ViewBag.Resultado = numero1 / numero2;
            }

            return View();
        }
    }
}