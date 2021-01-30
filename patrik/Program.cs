using System;
using System.Collections.Generic;
using Patrik.Modelos;

namespace Patrik
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente(1, "Patrik", "Masculino", "99-99999-9999");
            cliente.Salvar();

            cliente = new Cliente(2, "João da Silva", "Masculino", "99-99999-9999");
            cliente.Salvar();

            cliente = new Cliente(3, "Maria", "Feminino", "99-99999-9999");
            cliente.Salvar();

            List<Cliente> clientes = Cliente.ListarClientes();
            foreach (var item in clientes)
            {
                Console.WriteLine(item.imprimePessoa());
            }
        }
    }
}
