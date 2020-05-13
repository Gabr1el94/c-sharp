using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project_mvc_web.Models;

namespace project_mvc_web.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View("inicio");
        }


        [HttpGet]
        public ViewResult Formulario(){
            return View("formulario");
        }

        [HttpPost]
        public ViewResult Formulario(Convidados resposta){
            Repositorio.adicionarResposta(resposta);
            return View("obrigado",resposta);
        }

        public ViewResult ListConvidados(){
            return View("listaFinal", Repositorio.listarFinal.Where(c => c.Present == true));
        }
    }
}
