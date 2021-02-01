using DataBaseCamadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloCamadas
{
  public class PessoaFisica : Cliente
  {
    [CamposPersistido(NomeColuna = "Cpf_Cliente")]
    public int CPF { get; set; }

    public PessoaFisica()
    {

    }
    public PessoaFisica(int cpf)
    {
      this.CPF = cpf;
    }

    //Método Selado
    public sealed override void RetornaDadosCliente()
    {
      base.RetornaDadosCliente();
      Console.WriteLine($"CPF do Cliente: {CPF}");
    }
  }
}
