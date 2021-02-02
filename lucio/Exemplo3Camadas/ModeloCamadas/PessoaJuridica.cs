using DataBaseCamadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloCamadas
{
  public class PessoaJuridica : Cliente
  {
    [CamposPersistido(NomeColuna = "Cnpj_Cliente")]
    public int CNPJ { get; set; }

    public override void RetornaDadosCliente()
    {
      base.RetornaDadosCliente();
      Console.WriteLine($"CNPJ do Cliente: {CNPJ}");
    }
  }
}
