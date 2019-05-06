using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Douglas.Controllers 
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cabecalho()
        {
            return View();
        }

        public IActionResult Rodape()
        {
            return View();
        }
    }
}
