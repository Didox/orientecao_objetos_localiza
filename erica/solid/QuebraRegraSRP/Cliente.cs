using System;

namespace solid.QuebraRegra
{
    public class Cliente
    {
        public int id {get;set;}
        public string nome {get;set;}
        public string email {get;set;}
        public string celular {get;set;}

        public void ConectaDatabase(){
           Console.WriteLine("Conectando com database....");
        }

        public void EnviaEmail(){
            Console.WriteLine("Enviando e-mail para " + this.email);
        }

          public void EnviaSms(){
            Console.WriteLine("Enviando SMS para "  + this.celular);
        }
    }
}