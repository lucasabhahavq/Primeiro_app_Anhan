using Microsoft.AspNetCore.Mvc;

namespace Primeiro_app_Anhan.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nota = "Aluno nota 10";
            ViewData["escola"] = "EE Anhanguera";
            return View();
        }
    }
}
