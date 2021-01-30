using System;
using matheus.Modelos;

namespace matheus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cliente cliente = new Cliente();
            cliente.Id = 1;
            cliente.Nome = "Matheus Sinnis";
            cliente.Salvar();
            
            Cliente.Salvar(cliente);
                

            List<Cliente> listaCliente = Cliente.RetonaListaCliente();
        }
    }
}
