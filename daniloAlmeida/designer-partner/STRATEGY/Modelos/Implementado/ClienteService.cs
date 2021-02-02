using System.Collections.Generic;
using System.Linq;

namespace STRATEGY.Modelos.Implementado
{
    public static class ClienteService
    {
        public static class Cliente<T> where T : IPessoa 
    {

        private static List<T> _clientes { get; set; } = new List<T>();


        public static T Buscar(int id)
        {
            return _clientes.FirstOrDefault(e => e.Id == id);
        }    

        public static void Criar(T cliente)
        {
            _clientes.Add(cliente);
        }

        public static void Deletar(T cliente)
        {
            _clientes.Remove(cliente);
        }

        public static T Atualizar(T cliente)
        {
            var dado = Buscar(cliente.Id);

            dado.Nome = cliente.Nome;

            return dado;

        }
        public static List<T> ListaDeTodos()
        {
            return _clientes;
        }

    }
        
    }
}