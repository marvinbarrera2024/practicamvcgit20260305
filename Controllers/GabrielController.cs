using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practicamvcgit20260305.Models;

namespace practicamvcgit20260305.Controllers;

public class GabrielController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(double numero1, double numero2, string operacion)
    {
        double resultado = 0;
        string mensaje = "";

        switch (operacion)
        {
            case "sumar":
                resultado = numero1 + numero2;
                mensaje = $"La suma de {numero1} y {numero2} es {resultado}.";
                break;

            case "restar":
                resultado = numero1 - numero2;
                mensaje = $"La resta de {numero1} y {numero2} es {resultado}.";
                break;

            case "multiplicar":
                resultado = numero1 * numero2;
                mensaje = $"La multiplicación de {numero1} y {numero2} es {resultado}.";
                break;

            case "dividir":
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    mensaje = $"La división de {numero1} entre {numero2} es {resultado}.";
                }
                else
                {
                    mensaje = "No se puede dividir por cero.";
                }
                break;

            default:
                mensaje = "Operación no válida.";
                break;
        }

        ViewBag.resultado = resultado;
        ViewBag.mensaje = mensaje;
        ViewBag.numero1 = numero1;
        ViewBag.numero2 = numero2;
        ViewBag.operacion = operacion;

        return View();
    }
}
