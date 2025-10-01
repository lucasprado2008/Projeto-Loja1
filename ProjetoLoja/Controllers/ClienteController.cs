using Microsoft.AspNetCore.Mvc;

namespace ProjetoLoja.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
