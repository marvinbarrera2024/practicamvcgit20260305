using Microsoft.AspNetCore.Mvc;

public class Mii : Controller
{
    // Esta es la página cuando recién carga (GET)
    public IActionResult Index()
    {
        return View();
    }

    // Esta recibe los datos cuando presionas el botón (POST)
    [HttpPost]
    public IActionResult Index(double n1, double n2, string operacion)
    {
        double resultado = 0;
        string mensajeError = null;

        switch (operacion)
        {
            case "suma": resultado = n1 + n2; break;
            case "resta": resultado = n1 - n2; break;
            case "multi": resultado = n1 * n2; break;
            case "div":
                if (n2 != 0) resultado = n1 / n2;
                else mensajeError = "No se puede dividir por cero";
                break;
        }

        // Enviamos los datos de vuelta a la vista usando ViewBag
        ViewBag.Resultado = resultado;
        ViewBag.Error = mensajeError;
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;

        return View();
    }
}
