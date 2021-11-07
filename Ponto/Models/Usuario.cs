using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ponto.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string senha, string email)
        {
            Id = id;
            Senha = senha;
            Email = email;
        }
    }
}
