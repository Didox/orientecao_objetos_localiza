using System.Collections.Generic;
namespace Patrik.Modelos
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Genero { get; set; }
        public string Nome { get; set; }

        public Pessoa(int id, string genero, string nome)
        {
            this.Id = id;
            this.Genero = genero;
            this.Nome = nome;
        }

        public virtual string imprimePessoa()
        {
            return $"{Id}, {Nome}, {Genero}";
        }
    }
}
