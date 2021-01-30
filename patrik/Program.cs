﻿using System;
using System.Collections.Generic;
using Patrik.Modelos;

namespace Patrik
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.Id = 1;
            cliente.Nome = "Patrik";
            cliente.save();

            cliente = new Cliente();
            cliente.Id = 2;
            cliente.Nome = "Danilo";
            cliente.save();

            cliente = new Cliente();
            cliente.Id = 3;
            cliente.Nome = "João da Silva";
            cliente.save();

            List<Cliente> clientes = Cliente.listarClientes();
            foreach (var item in clientes)
            {
                Console.WriteLine(item);
            }
        }
    }
}