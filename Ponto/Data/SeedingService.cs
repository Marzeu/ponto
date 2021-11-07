using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ponto.Models;

namespace Ponto.Data
{
    public class SeedingService
    {
        private PontoContext _context;

        public SeedingService(PontoContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() ||
                _context.Pessoa.Any() ||
                _context.RegistroDePonto.Any())
            {
                return; // BD já foi populado.
            }

            Departamento d1 = new Departamento(new int(), "Recursos Humanos", "Rh");
            Departamento d2 = new Departamento(new int(), "Tecnologia da Informação", "Ti");

            Estado E1 = new Estado(new int(), "Santa Catarina", "SC");
            Estado E2 = new Estado(new int(), "São Paulo", "SP");
            Estado E3 = new Estado(new int(), "Rio de Janeiro", "RJ");
            Estado E4 = new Estado(new int(), "Minas Gerais", "MG");

            Cidade C1 = new Cidade(new int(), "Florianópolis", E1);
            Cidade C2 = new Cidade(new int(), "São José", E1);
            Cidade C3 = new Cidade(new int(), "São Paulo", E2);
            Cidade C4 = new Cidade(new int(), "Rio de Janeiro", E3);
            Cidade C5 = new Cidade(new int(), "Belo Horizonte", E4);

            Endereco end1 = new Endereco(new int(), "Rua Iguaçu", 123, "Saco dos Limões", "88045610", C1);
            Endereco end2 = new Endereco(new int(), "Av. Paulista", 12334, "Bela Vista", "15370496", C3);
            Endereco end3 = new Endereco(new int(), "Rua João Motta Espezim", 356, "Saco dos Limões", "88045000", C1);

            Pessoa p1 = new Pessoa(new int(), "Roberto Carlos", new DateTime(1920, 4, 21), "123456789-12", end1, d1);
            Pessoa p2 = new Pessoa(new int(), "Fafá de Belém", new DateTime(1945, 11, 23), "987654321-98", end2, d2);
            Pessoa p3 = new Pessoa(new int(), "Roberta Miranda", new DateTime(1955, 1, 04), "987654321-98", end3, d2);

            RegistroDePonto r1 = new RegistroDePonto(new int(), new DateTime(2021, 11, 7), new DateTime(2021, 11, 7), new DateTime(2021, 11, 7), new DateTime(2021, 11, 7), null, null, null, null, p1);
            RegistroDePonto r2 = new RegistroDePonto(new int(), new DateTime(2021, 11, 7), new DateTime(2021, 11, 7), new DateTime(2021, 11, 7), new DateTime(2021, 11, 7), null, null, null, null, p2);
            RegistroDePonto r3 = new RegistroDePonto(new int(), new DateTime(2021, 11, 7), new DateTime(2021, 11, 7), new DateTime(2021, 11, 7), new DateTime(2021, 11, 7), null, null, null, null, p3);

            _context.Departamento.AddRange(d1, d2);            
            _context.Pessoa.AddRange(p1, p2, p3);
            _context.RegistroDePonto.AddRange(r1, r2, r3);

            _context.SaveChanges();
        }
    }
}
