using System;

namespace Negocios
{
    public class Exemplo
    {
        public string exemploPai{get;set;}
        public virtual void Salvar(){
            Console.WriteLine("Salvar do pai.");
        }
    }
}