using System;

namespace Negocios
{
    public class ExemploFilho : Exemplo
    {
        public string exemploFilho{get;set;}

        public sealed override void Salvar(){
            Console.WriteLine("Salvar do filho");
            base.Salvar();
        }
        
    }
}