using System;

namespace Strategy.Modelos.Implementado
{
  public class Fisica : IPessoa, IFisica
  {
    public int Id {get;set;}
    public string Nome {get;set;}
    public string Telefone {get;set;}
    public string Email {get;set;}
    public string Cpf {get;set;}
  }
}