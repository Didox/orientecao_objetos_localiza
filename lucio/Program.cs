﻿using System;
using Modelo.Cliente;

namespace Lucio
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoDoNovoCliente = 10;
            string nomeDoNovoCliente = Cliente.AlterarNomeParaCaixaAlta("lucio pimenta");

            Cliente novoCliente = new Cliente(codigoDoNovoCliente, nomeDoNovoCliente);
            
            Console.WriteLine(novoCliente.Codigo);
            Console.WriteLine(novoCliente.Nome);
        }
    }
}
