using EntendendoMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntendendoMvc.Controllers
{
    [Route("")]
    [Route("controller-name")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("action-name")]
        [Route("action-name/{p1:int}/{p2?}")]
        //public IActionResult Index(int id, string categoria)
        public IActionResult Index(int p1, string p2)
        {
            //Filme f = new Filme();
            //f.Genero = "M";
            //return RedirectToAction("Privacy", f);
            return View();
        }

        [Route("pvy")]
        [Route("privacidade")]
        public IActionResult Privacy(Filme f)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
            //return Content("conteúdo");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}