using System;
using Danilo.Modelos;
using Negocios;

namespace Danilo
{
    class Program
    {
        static void Main(string[] args)
        {
            // var cliente = new Cliente("nome", "nome");
            var cliente = new Cliente(string.Empty, "Aparecido")
            {
                Nome = "nome",
            };

            //cliente.Sobrenome = "dsdsds";

            cliente.Salvar();
            cliente.Id = 1;
            cliente.Tipo = TipoCliente.Basic;
            cliente.EscreveNaTelaAlgo();

            var lista = Cliente.BuscaPorNome("ds");

            var carro = new Carro();
            carro.Ano = 11;
        }
    }
}