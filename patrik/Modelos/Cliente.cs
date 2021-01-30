using System.Collections.Generic;
using Patrik.Modelos;
namespace Patrik.Modelos
{
    class Cliente : Pessoa
    {
        public Cliente(int id, string genero, string nome, string telefone): base(id, genero, nome)
        {
            Telefone = telefone;   
        }
        public string Telefone { get; set; }
        private static List<Cliente> ListaDeClientes = new List<Cliente>();

        public void Salvar()
        {
          Cliente.ListaDeClientes.Add(this);
        }

        public static List<Cliente> ListarClientes ()
        {
          return ListaDeClientes;
        }

        public override string imprimePessoa()
        {
            var stringPessoa = base.imprimePessoa();
            return $"{stringPessoa}, {Telefone}";
        }



        public override string ToString()
        {
            return "[" + Id + ", " + Nome + "]";
        }
    }
}
