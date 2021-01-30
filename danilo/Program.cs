using System;
using Danilo.Modelos;

namespace Danilo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.Id = 0;
            cliente.Nome = "Danilo";
            cliente.Salvar();

            var lista = Cliente.BuscaPorNome("ds");

            Console.WriteLine("Hello World!");
        }
    }
}
