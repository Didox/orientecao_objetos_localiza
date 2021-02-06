using Microsoft.EntityFrameworkCore;
using PersistenceLayer.Models;
using System.Threading.Tasks;

namespace PersistenceLayer.Infrastructure.Database
{
    public class EFCoreDatabase<Entity> : IDataQuery<Entity> where Entity : BaseModel
    {
        public void Update(Entity obj)
        {
            var _dbContext = new EFDbContext();
            var dbSet = _dbContext.Set<Entity>();
            _dbContext.Entry(obj).State = EntityState.Modified;
            if (obj != null)
            {
                dbSet.Update(obj);
                _dbContext.SaveChanges();
            }
        }

        public async void Remove(int id)
        {
            var _dbContext = new EFDbContext();
            var dbSet = _dbContext.Set<Entity>();
            var obj = await this.GetByIdAsync(id);
            if (obj != null)
            {
                dbSet.Remove(obj);
                _dbContext.SaveChanges();
            }
        }

        public void Save(Entity obj)
        {
            var _dbContext = new EFDbContext();
            var dbSet = _dbContext.Set<Entity>();
            dbSet.Add(obj);
            _dbContext.SaveChanges();
        }


        public async Task<Entity> GetByIdAsync(int id)
        {
            var _dbContext = new EFDbContext();
            var dbSet = _dbContext.Set<Entity>();
            return await dbSet.FindAsync(id);
        }

    }
}
