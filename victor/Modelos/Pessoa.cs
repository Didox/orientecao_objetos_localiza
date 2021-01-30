using System;

namespace Victor.Modelos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        protected string Telefone { get; set; }

        public Pessoa()
        {
            
        }
        public Pessoa(string telefone)
        {
            this.Telefone = telefone;
        }

        public virtual void EscreveNaTelaAlgo()
        {
            Console.WriteLine("Eu sou o método da classe PAI!");
        }
    }
}