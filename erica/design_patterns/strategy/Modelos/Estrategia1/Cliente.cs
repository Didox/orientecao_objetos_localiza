using System;

namespace strategy.Modelos.Estrategia1
{
    public class Cliente
    {
        public int id {get;set;}
        public string nome {get;set;}
        public string telefone {get;set}
        public string email {get; set;}
        public TipoCliente tipoCliente {get;set;}

         public void Salvar()
    {
      if(this.Tipo == TipoCliente.Fisica)
      {
        Console.WriteLine("Salvo como pessoa Fisica");
      }
      else if(this.Tipo == TipoCliente.Jurifica)
      {
        Console.WriteLine("Salvando como pessoa Juridica");
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