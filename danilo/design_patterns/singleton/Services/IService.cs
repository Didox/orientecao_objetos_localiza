

using System;

namespace Strategy.Services
{
  public interface IService 
  {
    void Enviar<T>(T obj);
  }
}
