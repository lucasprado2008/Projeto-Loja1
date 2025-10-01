using Microsoft.AspNetCore.Mvc;

namespace ProjetoLoja.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
