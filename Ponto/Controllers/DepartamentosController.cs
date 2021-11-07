using Microsoft.AspNetCore.Mvc;
using Ponto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ponto.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Recursos Humanos", Sigla = "Rh" });
            list.Add(new Departamento { Id = 2, Nome = "Tecnologia da Informação", Sigla = "Ti" });

            return View(list);
        }
    }
}
