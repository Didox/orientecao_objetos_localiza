using System;
using Negocios;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var carroSms = new Carro();
            carroSms.EnviarSms();

           new Carro()
            {
                Id = 1,
                Nome = "Uno",
                //Telefone = "12222",
                Ano = 2021,
                Descricao = "Um teste"
            }.Salvar();

             var carros = Carro.Todos();
            foreach(var carro in carros)
            {
                var cCast = (Carro)carro;
                Console.WriteLine($"Nome: {cCast.Nome}");
            }

            var modelos = NegocioService.Todos<Modelo>();
            foreach (var modelo in modelos)
            {
                Console.WriteLine($"Nome: {modelo.Nome}");
            }

            new Modelo() { Nome = "Uno teste" }.Salvar();

        }
    }
}