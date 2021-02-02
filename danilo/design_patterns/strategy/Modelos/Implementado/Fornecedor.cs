using System;

namespace Strategy.Modelos.Implementado
{
  public class Fornecedor : IPessoa, IJuridica, IFornecedor
  {
    public int Id {get;set;}
    public string Nome {get;set;}
    public string Telefone {get;set;}
    public string Email {get;set;}
    public string Cnpj {get;set;}
    public string RazaoSocial {get;set;}
    public string CodigoCRM { get;set; }
  }
}