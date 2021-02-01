using DataBaseCamadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloCamadas
{
  public partial class Cliente : BaseService
  { 
    [CamposPersistido(NomeColuna = "Cod_Cliente")]
    public int Codigo { get; set; }

    [CamposPersistido(NomeColuna = "Nome_Cliente")]
    public string Nome { get; set; }

    [CamposPersistido(NomeColuna = "Idade_Cliente")]
    public int Idade { get; set; }

    public Cliente()
    {

    }
    public Cliente(int novoCodigo, string novoNome, int idadeCliente)
    {
      this.Codigo = novoCodigo;
      this.Nome = novoNome;
      this.Idade = idadeCliente;
    }

    public virtual void RetornaDadosCliente()
    {
      Console.WriteLine($"Nome do Cliente: {Nome}");
    }
   
  }
}
