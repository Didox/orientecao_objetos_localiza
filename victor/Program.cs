using System;
using Victor.Modelos;

namespace Victor
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();

            cliente.Id = 0;

            Console.WriteLine("Digite o seu nome");
            cliente.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite a sua idade");
            cliente.Idade = Convert.ToInt32(Console.ReadLine());

            cliente.Salvar();

        }
    }
}
