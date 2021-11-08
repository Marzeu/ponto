using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ponto.Controllers
{
    public class PessoasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
