using System;
using System.Collections.Generic;

namespace Perfistencia.Infrastructure.Database
{
  public interface IRelationalDatabase<T> where T : class
  {
    void Save(T obj);
    List<T> All();
    void Remove(T obj);
  }
}