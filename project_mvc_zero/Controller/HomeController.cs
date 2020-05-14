using System;
using Microsoft.AspNetCore.Mvc;
namespace project_mvc_zero.Controler
{
    public class HomeController : Controller
    {
        [ViewData]
        public string nome { get; set; }

        public IActionResult Index()
        {
            return View();
        }

         public IActionResult pag1()
        {
            // ViewBag.mensagem1=  "Esta é a mensagem para página 1";
            // ViewBag.mensagem2=  "Bem-vindo a página";
            return View();
        }

         public IActionResult pag2()
        {
            // ViewData["nome"]="Gabriel";
            // ViewData["apelido"]="Soares";
            return View();
        }

         public IActionResult pag3()
        {
            this.nome="Gabriel";
            return View();
        }
     
    }
    
}