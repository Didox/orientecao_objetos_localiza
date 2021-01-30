using System;
using lucio.Modelo;
using Modelo.Cliente;

namespace Lucio
{
    class Program
    {
        static void Main(string[] args)
        {            

            PessoaFisica novoClientePessoaFisica = new PessoaFisica();

            novoClientePessoaFisica.Nome = Cliente.AlterarNomeParaCaixaAlta("cliente pessoa fisica");
            novoClientePessoaFisica.CPF = 123456789;

            novoClientePessoaFisica.RetornaDadosCliente();

            PessoaJuridica novoClientePessoaJuridica = new PessoaJuridica();

            novoClientePessoaJuridica.Nome = Cliente.AlterarNomeParaCaixaAlta("cliente Pessoa Juridica");
            novoClientePessoaJuridica.CNPJ = 000100010001;

            novoClientePessoaJuridica.RetornaDadosCliente();
        }
    }
}
