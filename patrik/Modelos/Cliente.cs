using System.Collections.Generic;
namespace Patrik.Modelos
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Cliente> listaDeClientes = new List<Cliente>();

        public void save()
        {
          Cliente.listaDeClientes.Add(this);
        }

        public static List<Cliente> listarClientes ()
        {
          return listaDeClientes;
        }

        public override string ToString()
        {
            return "[" + Id + ", " + Nome + "]";
        }
    }
}
