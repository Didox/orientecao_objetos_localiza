using System;
using erica.Modelos;

namespace erica
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.id = 1;
            cliente.Nome = "Erica Viana";
            cliente.Salvar();

            Console.WriteLine("Hello World!");
        }
    }
}
