using System;
using Victor.Modelos;

namespace Victor
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("Victor","123123213");

            cliente.Tipo = TipoCliente.Basic;

            System.Console.WriteLine("Digite a sua idade");
            cliente.Idade = Convert.ToInt32(Console.ReadLine());

            cliente.EscreveNaTelaAlgo();
            cliente.Salvar();

        }
    }
}
