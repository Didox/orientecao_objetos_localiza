using System;
using hugo.Modelos;

namespace hugo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.Id = 1;
            cliente.Nome = "Hugo";
            cliente.Salvar();

            Cliente.BuscaPorNome("Hugo");
            Console.WriteLine("Cliente "+cliente.Nome+" cadastrado");
        }
    }
}
