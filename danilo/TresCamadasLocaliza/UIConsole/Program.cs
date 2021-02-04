using System;
using Negocio;

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
                Nome = "Danilo",
                Telefone = "12222",
                Ano = 2021,
                Descricao = "Um teste"
            }.Salvar();
          
            var carros = Carro.Todos();
            foreach(var carro in carros)
            {
                var cCast = (Carro)carro;
                Console.WriteLine($"Nome: {cCast.Nome}");
            }

            var carros2 = NegocioService.Todos<Carro>();
            foreach (var carro in carros2)
            {
                Console.WriteLine($"Nome: {carro.Nome}");
            }

            var modelos = NegocioService.Todos<Modelo>();
            foreach (var modelo in modelos)
            {
                Console.WriteLine($"Nome: {modelo.Nome}");
            }

            //NegocioService.Salvar(new Modelo() { Nome = "Danilo" });

            new Modelo() { Nome = "Danilo" }.Salvar();
        }
    }
}