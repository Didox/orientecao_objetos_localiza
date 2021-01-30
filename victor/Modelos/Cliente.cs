using System;

namespace Victor.Modelos
{
    public class Cliente : Pessoa
    {
        //Construtores
        public Cliente() { }

        public Cliente(string nome, string telefone) :base (telefone)
        {
            this.Nome = nome;
        }
        // Declaração de atributos
        private int Id { get; set; }
        public TipoCliente Tipo { get; set; }

        //Sobrescrição de método 
        public override void EscreveNaTelaAlgo()
        {
            Console.WriteLine("Eu sou o método filho!");
            base.EscreveNaTelaAlgo();
        }

        //Criação de um método
        public void Salvar()
        {
            Console.WriteLine("Usuário cadastrado com sucesso!");
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("Telefone: " + this.Telefone);
        }
    }
}