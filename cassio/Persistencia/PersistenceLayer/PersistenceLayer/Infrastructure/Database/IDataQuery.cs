using PersistenceLayer.Models;
using System.Threading.Tasks;

namespace PersistenceLayer.Infrastructure.Database
{
    public interface IDataQuery<Entity> where Entity : BaseModel
    {
        void Save(Entity obj);
        void Update(Entity obj);
        void Remove(int id);
        Task<Entity> GetByIdAsync(int id);
    }
}
