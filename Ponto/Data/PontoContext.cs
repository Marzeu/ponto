using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ponto.Models;

namespace Ponto.Models
{
    public class PontoContext : DbContext
    {
        public PontoContext (DbContextOptions<PontoContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<RegistroDePonto> RegistroDePonto { get; set; }

    }
}
