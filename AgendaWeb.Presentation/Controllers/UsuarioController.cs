using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Presentation.Controllers
{
    public class UsuarioController : Controller
    {
        //método para abrir a página 'MinhaConta'
        public IActionResult MinhaConta()

        {
            return View();
        }
    }
}
