using System.Collections.Generic;
namespace Patrik.Modelos
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        private static List<Cliente> ListaDeClientes = new List<Cliente>();

        public void Salvar()
        {
          Cliente.ListaDeClientes.Add(this);
        }

        public static List<Cliente> ListarClientes ()
        {
          return ListaDeClientes;
        }

        public override string ToString()
        {
            return "[" + Id + ", " + Nome + "]";
        }
    }
}
