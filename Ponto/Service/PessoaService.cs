using Ponto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ponto.Service
{
    public class PessoaService
    {
        private readonly PontoContext _context;

        public PessoaService(PontoContext context)
        {
            _context = context;
        }

        public List<Pessoa> FindAll()
        {
            return _context.Pessoa.ToList();
        }
    }
}
