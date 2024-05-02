using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Imobiliaria.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string nome, int idade=1)
        {
            ViewData["Mensagem"] = "Olá "+nome;
            ViewData["Idade"] = idade;
            return View();
        }

    }
}