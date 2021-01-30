using System;

namespace erica.Modelos
{
    public class Usuario
    {
         private int id {get;set;}
         private string usuario {get;set;}
         private string senha {get;set;}

         public void informaUsuarioESenha(){
             Console.WriteLine("O usuário é: " + this.usuario + "e a senha é: " + this.senha);
         }
    }
}