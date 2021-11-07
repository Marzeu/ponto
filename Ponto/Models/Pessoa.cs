using System;
using System.Collections.Generic;
using System.Linq;

namespace Ponto.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroDePonto> RegistrosDePonto { get; set; } = new List<RegistroDePonto>();

        public Pessoa()
        {
        }

        public Pessoa(int id, string nome, DateTime dataNascimento, string cpf, Endereco endereco, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Endereco = endereco;
            Departamento = departamento;
        }

        public void AdicionarEntrada(RegistroDePonto entrada)
        {
            RegistrosDePonto.Add(entrada);
        }

        public void RemoverEntrada(RegistroDePonto entrada)
        {
            RegistrosDePonto.Remove(entrada);
        }

        public void AdicionarSaida(RegistroDePonto saida)
        {
            RegistrosDePonto.Add(saida);
        }

        public void RemoverSaida(RegistroDePonto saida)
        {
            RegistrosDePonto.Remove(saida);
        }

        //public double TotalDeRegistros(DateTime inicial, DateTime final) pensar em como resolver 
        //{
        //    return RegistrosDePonto.Where(registros => registros. >= inicial && registros.Date <= final);
        //}
    }
}
