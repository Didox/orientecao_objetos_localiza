using System;
using System.Collections.Generic;

namespace Danilo.Modelos
{
  public class Pessoa
  {
    public Pessoa() {}
    public Pessoa(string nome, string sobrenome)
    {
        this.sobrenome = sobrenome;
    }

    private string sobrenome;
    protected int codigo{get;set;}
    public int Id{get;set;}

    public virtual void EscreveNaTelaAlgo()
    {
      Console.WriteLine($"Eu sou o método original - sobrenome do contrutor original {sobrenome}");
    }

  }
}
