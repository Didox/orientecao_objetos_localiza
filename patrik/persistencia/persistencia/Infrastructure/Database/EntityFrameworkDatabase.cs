using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

    public List<T> All(string sqlWhere = null)
    {
      var context = new EntityContext();
      var queryable = context.Set<T>();
      return queryable.ToList<T>();
    }
    public void Remove(T obj)
    {
      var ctx = new EntityContext();
      ctx.Entry(obj).State = EntityState.Deleted;
      ctx.SaveChanges();
    }
  }
}