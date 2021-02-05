using System;
using System.Collections.Generic;
using System.Linq;

namespace Perfistencia.Infrastructure.Database
{
    public class EntityFrameworkDatabase<T> : IDatabase<T> where T : class
    {

        protected EntityContext Db = new EntityContext();

        public void Save(T obj)
        {
            Db.Add(obj);
            Db.SaveChanges();
        }

        public void Update(T obj)
        {
            Db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Db.SaveChanges();
        }

        public List<T> All(string sqlWhere = null)
        {
            return Db.Set<T>().ToList();
        }
        public void Remove(T obj)
        {
            Db.Set<T>().Remove(obj);
            Db.SaveChanges();
        }
    }
}