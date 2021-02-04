using System.Net.Security;
using System.IO.Pipes;
using System.Net.WebSockets;
using System.Net.Http;
using System;
using AtivPOO.daniloAlmeida.Modelos;

namespace DaniloAlmeida
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();

            cliente.Id = 1;
            cliente.Nome = "Danilo";

            cliente.SalvarBanco();
            Cliente.BuscarNoBanco("Danilo");
            cliente.Tipo = TipoCliente.Basico;
        }
    }
} 