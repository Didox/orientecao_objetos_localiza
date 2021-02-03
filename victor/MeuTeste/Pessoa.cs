using System.Collections.Generic;

namespace MeuTeste
{
    public class Pessoa : IPessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public void Salvei()
        {
            System.Console.WriteLine("FOI!");
        }

        public void Salvar(Pessoa p)
        {
            this.Id = p.Id;
            this.Nome = p.Nome;
            System.Console.WriteLine("Salvando Objeto");
        }

        public List<T> Listar<T>()
        {
            return new List<T>();
            System.Console.WriteLine("Retornando Lista");
        }
    }
}
