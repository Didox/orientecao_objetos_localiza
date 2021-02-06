using System;
using System.Collections.Generic;

namespace Perfistencia.Infrastructure.Database
{
  public interface IDocumentDatabase
  {
    void Save<T>(T obj);
    List<T> All<T>();
    void Remove<T>(T obj);
  }
}