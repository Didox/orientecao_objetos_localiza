using System;
using Negocio;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new Carro{
                Id = 1,
                Nome = "Danilo"
            }.Salvar();            
            
            Console.WriteLine("Hello World!");
        }
    }
}
