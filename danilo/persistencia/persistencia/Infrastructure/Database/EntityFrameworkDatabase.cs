using System;
using System.Collections.Generic;

namespace Perfistencia.Infrastructure.Database
{
  public class EntityFrameworkDatabase<T> : IDatabase<T> where T : class
  {
    public void Save(T obj)
    {
      var context = new EntityContext();
      var dbSet = context.Set<T>();
      dbSet.Add(obj);
      context.SaveChanges();
    }

    public List<T> All()
    {
      throw new Exception("Falta fazer");
    }
    public void Remove(T obj)
    {
      throw new Exception("Falta fazer");
    }
  }
}