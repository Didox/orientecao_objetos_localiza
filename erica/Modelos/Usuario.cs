using System;

namespace erica.Modelos
{
    public class Usuario
    {
         private int id {get;set;}
         protected string usuario {get;set;}

         public virtual void informaDadosUsuario(){
             Console.WriteLine("Dados do usuário (pai): " + this.usuario);
         }
    }
}