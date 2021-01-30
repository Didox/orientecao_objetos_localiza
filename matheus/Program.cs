using System;
using matheus.Modelos;

namespace matheus
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaCorrente = new ContaCorrente(1);
            contaCorrente.Depositar();
            
            Cliente cliente = new Cliente();
            cliente.Id = 1;
            cliente.Nome = "Matheus Sinnis";
            cliente.Salvar();
            
            Cliente.Salvar(cliente);
                

        }
    }
}
