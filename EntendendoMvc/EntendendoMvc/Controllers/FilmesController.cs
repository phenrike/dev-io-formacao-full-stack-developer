using EntendendoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntendendoMvc.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {
                // TODO: Gravar no banco de dados
            }
            return View(filme);
        }
    }
}
