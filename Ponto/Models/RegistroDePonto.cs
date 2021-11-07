using System;

namespace Ponto.Models
{
    public class RegistroDePonto
    {
        public int Id { get; set; }
        public DateTime Entrada1 { get; set; }
        public DateTime Saida1 { get; set; }
        public DateTime Entrada2 { get; set; }
        public DateTime Saida2 { get; set; }
        public DateTime Entrada3 { get; set; }
        public DateTime Saida3 { get; set; }
        public DateTime Entrada4 { get; set; }
        public DateTime Saida4 { get; set; }
        public Pessoa Pessoa { get; set; }

        public RegistroDePonto()
        {
        }

        public RegistroDePonto(int id, DateTime entrada1, DateTime saida1, DateTime entrada2, DateTime saida2, DateTime entrada3, DateTime saida3, DateTime entrada4, DateTime saida4, Pessoa pessoa)
        {
            Id = id;
            Entrada1 = entrada1;
            Saida1 = saida1;
            Entrada2 = entrada2;
            Saida2 = saida2;
            Entrada3 = entrada3;
            Saida3 = saida3;
            Entrada4 = entrada4;
            Saida4 = saida4;
            Pessoa = pessoa;
        }
    }
}
