using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ponto.Models;

namespace Ponto.Data
{
    public class PontoContext : DbContext
    {
        public PontoContext (DbContextOptions<PontoContext> options)
            : base(options)
        {
        }

        public DbSet<Ponto.Models.Departamento> Departamento { get; set; }
    }
}
