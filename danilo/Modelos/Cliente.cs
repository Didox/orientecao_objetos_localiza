using System;
using System.Collections.Generic;

namespace Danilo.Modelos
{
    public class Cliente
    {
       public int Id{ get; set; }
       public string Nome{ get; set; }

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
