using System;
using System.Collections.Generic;

namespace hugo.Modelos
{
    public class Cliente : Pessoa
    {

        private string telefone { get; set; }
        public Cliente(){}
       
        public Cliente(string nome, int idade) :base (nome, idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        

            
        public override void exibeNomeNaTela()
        {
            Console.WriteLine($"Exibe nome metodo Filho");
            base.exibeNomeNaTela();
        }
        
    }
}
        