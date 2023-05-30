using Microsoft.AspNetCore.Mvc;

namespace TP4BIS.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPaíses=Info.ListarPaíses();
        return View("index");
    }
    public IActionResult DetallePaís(string País)
    {
        ViewBag.PaísBuscado=Info.DetallePais(País);
        return View("detallePaís");
    }
}
