using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Douglas.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Cliente()
        {
            return View();
        }
    }
}
