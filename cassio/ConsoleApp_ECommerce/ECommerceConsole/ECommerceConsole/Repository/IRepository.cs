using ECommerceConsole.Models;
using System.Collections.Generic;

namespace ECommerceConsole.Repository
{
    public interface IRepository<Entity>
        where Entity : EntidadeBase
    {
        abstract void Salvar(Entity entidade);
        abstract List<Entity> Listar();
        abstract void PegarPorId(int id);

    }
}
