using System;

namespace erica.Modelos
{
    public class PessoaFisica : Usuario
    {
        public string cpf {get;set;}

         public new void informaDadosUsuario(){
             Console.WriteLine("O CPF do usuário é: " + this.cpf);
             base.informaDadosUsuario();
         }
        
    }
}