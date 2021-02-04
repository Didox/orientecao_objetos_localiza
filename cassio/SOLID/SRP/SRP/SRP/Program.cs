using SRP.NaRegra.Models;
using SRP.NaRegra.Repository;
using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repository = new AulaRepository();

            var Aula = new Aula
            {
                Nome = "SOLID",
                Tema = "Single Responsiblity Principle (Princípio da responsabilidade única)"
            };

            _repository.Salvar(Aula);

        }
    }
}
