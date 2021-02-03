using ECommerceConsole.Models;
using System;
using System.Collections.Generic;

namespace ECommerceConsole.Repository
{
    public class Repository<Entity> : IRepository<Entity>
        where Entity : EntidadeBase
    {
        public virtual void Salvar(Entity entidade)
        {
            Console.WriteLine($"Salvando {entidade.GetType().Name}");
        }
        public virtual List<Entity> Listar()
        {
            return new List<Entity>();
        }
        public virtual void PegarPorId(int id)
        {
            Console.WriteLine($"Retornando Entidade encontrada pelo Id...");

        }
    };
}
