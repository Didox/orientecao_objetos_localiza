using System;
using Modelo.Cliente;

namespace lucio.Modelo
{
    public class PessoaFisica : Cliente
    {
        public int CPF { get; set; }

        public PessoaFisica()
        {
            
        }
        public PessoaFisica(int cpf)
        {
            this.CPF = cpf;
        }
        public override void RetornaDadosCliente()
        {
            base.RetornaDadosCliente();
            Console.WriteLine($"CPF do Cliente: {CPF}");
        }

    }
}