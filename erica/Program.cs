using System;
using erica.Modelos;

namespace erica
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cliente = new Cliente();
            //cliente.id = 1;
            //cliente.Nome = "Erica Viana";
            //cliente.Salvar();

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.cpf = "1234";

            pessoaFisica.informaDadosUsuario();

            //Console.WriteLine("Hello World!");
        }
    }
}
