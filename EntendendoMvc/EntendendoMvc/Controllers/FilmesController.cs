﻿using Microsoft.AspNetCore.Mvc;

namespace EntendendoMvc.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
    }
}
