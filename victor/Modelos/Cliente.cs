using System;

namespace Victor.Modelos
{
    public class Cliente
    {
        private string nome;
        public int Idade { get; set; }
        public int Id { get; set; }

        public string Nome
        {
            get
            {
                return this.nome.ToUpper();
            }
            set
            {
                this.nome = value.ToLower();
            }
        }

        public void Salvar()
        {
            Console.WriteLine("Usuário cadastrado com sucesso!");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Idade: " + this.Idade);
        }
    }
}