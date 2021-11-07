using System.Collections.Generic;

namespace Ponto.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public ICollection<Pessoa> Pessoas { get; set; } = new List<Pessoa>();

        public Departamento() 
        {
        }

        public Departamento(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public void RemoverPessoa(Pessoa pessoa)
        {
            Pessoas.Remove(pessoa);
        }

    }
}
