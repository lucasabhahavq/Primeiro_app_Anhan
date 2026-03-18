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
    
    public IActionResult Teste()
    {
            TempData["MSG_EX"] = "Mensagem do TempData";
            return RedirectToAction("Resultado");
    }
        public IActionResult Resultado()
        {
            if (TempData["MSG_EX"] != null)
                ViewBag.Exemplo = "Aluno ETEC MB";
            return View();

        }
    } 
}
