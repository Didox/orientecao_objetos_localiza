using System;
using System.Collections.Generic;

namespace Strategy.Modelos.Estrategia1
{
  public class Cliente
  {
    public const int FISICA = 1;
    public const int JURIDICA = 2;

    public int Id {get;set;}
    public string Nome {get;set;}
    public string Telefone {get;set;}
    public string Email {get;set;}
    public string Cpf {get;set;}
    public string Cnpj {get;set;}
    public string RazaoSocial {get;set;}
    public TipoCliente Tipo {get;set;}

    public void Salvar()
    {
      if(this.Tipo == TipoCliente.Fisica)
      {
        Console.WriteLine("Salvo no banco de dados para pessoa fisica");
      }
      else if(this.Tipo == TipoCliente.Jurifica)
      {
        Console.WriteLine("Salvo no banco de dados para pessoa Jurifica");
      }
      else if(this.Tipo == TipoCliente.Fornecedor)
      {
        Console.WriteLine("Salvo no banco de dados para pessoa fornecedor");
      }
    }

    public static List<Cliente> Todos(TipoCliente? tipo = null)
    {
      if(tipo == null) return new List<Cliente>();

      if(tipo == TipoCliente.Fisica)
      {
        return new List<Cliente>();
      }
      else if(tipo == TipoCliente.Jurifica)
      {
        return new List<Cliente>();
      }
      else
      {
        return new List<Cliente>();
      }
    }
  }
}