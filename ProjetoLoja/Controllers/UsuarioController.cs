// IMPORTANDO PACOTES PARA UTILIZAR NO PROJETO
using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Models;
using ProjetoLoja.Repositorio;

// DEFINE O NOME E ONDE A CLASSE ESTÁ LOCALIZADA, NAMESPACE AJUDA A ORGANIZAR O CÓDIGO E EVITAR CONFLITOS DE NOMES
namespace ProjetoLoja.Controllers
{
    // CLASSE USUARIOCONTROLLER QUE ESTÁ HERDANDO DA CLASSE CONTROLLER
    public class UsuarioController : Controller
    {
        // DECLARA UMA VARIÁVEL PRIVADA, SOMENTE LEITURA DO TIPO UsuarioRepositorio CHAMADA (INSTANCIAR) _usuarioRepositorio
        // UsuarioRepositorio É UMA CLASSE RESPONSÁVEL POR INTERAGIR COM A CAMADA DE DADOS E GERENCIAR AS INFORMAÇÕES DO USUARIO
        private readonly UsuarioRepositorio _usuarioRepositorio;

        //CONSTRUTOR QUE RECEBE A INSTÂNCIA UsuarioRepositorio COM PARÂMETROS (INJEÇÃO DE DEPENDÊNCIA)
        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        // INTERFACE É UMA REPRESENTAÇÃO DO RESULTADO (TELA)
        [HttpGet]
        public IActionResult Login()
        {
            // RETORNA A PÁGINA LOGIN
            return View();
        }

        [HttpPost]
        public IActionResult Login(String email, String senha)
        {
            var Usuario = _usuarioRepositorio.ObterUsuario(email);
            if (Usuario != null && Usuario.Senha == senha)
             //senha = Senha do banco; Senha = Senha do Input
            {
                return RedirectToAction("Index","Home");
            }
            ModelState.AddModelError("", "Email / Senha inválidos");

            // RETORNA A PÁGINA LOGIN
            return View();
        }
    }
}
