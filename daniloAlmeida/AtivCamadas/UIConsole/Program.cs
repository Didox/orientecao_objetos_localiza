using System;
using Negocio;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro{
                Id = 1,
                Nome = "Danilo"
            };

            CarrosService.Salvar(carro);            
            
            Console.WriteLine("Hello World!");
        }
    }
}
