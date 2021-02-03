using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static partial class Contexto<T> where T : Entity
    {

        private static List<T> _entities { get; set; } = new List<T>();


        public static T Buscar(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }    

        public static void Criar(T entity)
        {
            _entities.Add(entity);
        }

        public static void Deletar(T entity)
        {
            _entities.Remove(entity);
        }

        public static T Atualizar(T entity)
        {
            var dado = Buscar(entity.Id);

            dado.Nome = entity.Nome;

            return dado;

        }
        public static List<T> ListaDeTodos()
        {
            return _entities;
        }

    }
}
