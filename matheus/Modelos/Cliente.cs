using System;
using System.Collections.Generic;

namespace matheus.Modelos
{
    public class Cliente
    {
       public int Id {get; set;}
       public string Nome {get; set;}

       public void Salvar()
       {
           //instancia this
           //Salvar
       }
        
       public static void Salvar(Cliente salvar)
       {
           
           //Salvar
       }

       public static List<Cliente> RetonaListaCliente()
       {
           return new List<Cliente>();
       }
    }


}
