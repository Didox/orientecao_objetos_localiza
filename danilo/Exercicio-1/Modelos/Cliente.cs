using System;
using System.Collections.Generic;

namespace Danilo.Modelos
{
  public class Cliente : Pessoa
  {
    public Cliente() { }
    public Cliente(string nome, string sobrenome) : base(nome, sobrenome)
    {
        this.Nome = nome;
        this.Sobrenome = sobrenome;
    }

    public override void EscreveNaTelaAlgo()
    {
      Console.WriteLine("Eu sou o método do filho");
      base.EscreveNaTelaAlgo();
    }

    public string Nome { get; set; }
    public string Sobrenome { get; private set; }
    public TipoCliente Tipo { get; set; }

    public void Salvar()
    {
      Console.WriteLine("Salvando no banco");
    }

    public static List<Cliente> BuscaPorNome(string nome)
    {
      return new List<Cliente>();
    }

  }
}
