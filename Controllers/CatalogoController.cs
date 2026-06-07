using Microsoft.AspNetCore.Mvc;

namespace Catalogo_de_produtos_Uninove.Controllers
{
    public class CatalogoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Produtos = new List<string>
            {
                "Mouse Gamer",
                "Teclado Mecânico",
                "Monitor",
                "Headset",
                "Webcam"
            };

            ViewBag.Precos = new List<decimal>
            {
                79.90m,
                249.90m,
                899.90m,
                149.90m,
                99.90m
            };

            return View();
        }
    }
}