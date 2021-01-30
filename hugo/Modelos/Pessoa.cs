using System;

namespace hugo.Modelos
{
    public class Pessoa
    {
        public int Id { get; set;}
        public string Nome { get; set;}

        protected int Idade { get; set; }
        
        public Pessoa(){
            
        }
        public Pessoa( string nome, int idade){
            this.Nome = nome;
            this.Idade = idade;
        }

       
        public virtual void exibeNomeNaTela(){
            Console.WriteLine($"Exibe nome classe Pai");
        }
    }
}