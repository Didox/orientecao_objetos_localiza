using System;
using daniloAlmeida.Modelos;

namespace DaniloAlmeida
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();

            cliente.Nome = "Danilo";
            cliente.SalvarBanco();
           

        }
    }
} 