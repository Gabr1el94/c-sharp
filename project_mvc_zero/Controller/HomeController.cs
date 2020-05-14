using System;
using Microsoft.AspNetCore.Mvc;
namespace project_mvc_zero.Controler
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

         public IActionResult pag1()
        {
            return View();
        }

         public IActionResult pag2()
        {
            return View();
        }

         public IActionResult pag3()
        {
            return View();
        }
     
    }
    
}