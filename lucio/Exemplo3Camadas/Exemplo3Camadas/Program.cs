using ModeloCamadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3Camadas
{
  class Program
  {
    static void Main(string[] args)
    {
      PessoaFisica novoClientePessoaFisica = new PessoaFisica();

      novoClientePessoaFisica.Nome = Cliente.AlterarNomeParaCaixaAlta("cliente pessoa fisica");
      novoClientePessoaFisica.CPF = 123456789;

      novoClientePessoaFisica.RetornaDadosCliente();
      novoClientePessoaFisica.Salvar();

      PessoaJuridica novoClientePessoaJuridica = new PessoaJuridica();

      novoClientePessoaJuridica.Nome = Cliente.AlterarNomeParaCaixaAlta("cliente Pessoa Juridica");
      novoClientePessoaJuridica.CNPJ = 000100010001;

      novoClientePessoaJuridica.RetornaDadosCliente();
      novoClientePessoaJuridica.Salvar();
    }
  }
}
