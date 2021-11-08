using Microsoft.AspNetCore.Mvc;
using Ponto.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ponto.Controllers
{
    public class PessoasController : Controller
    {

        private readonly PessoaService _pessoaService;

        public PessoasController(PessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }
        public IActionResult Index()
        {
            var pessoas = _pessoaService.FindAll();
            return View(pessoas);
        }
    }
}
