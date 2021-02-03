using System.Collections.Generic;

namespace BancoDeDados.Repositorios
{
    public interface IRepositorioProvider
    {
        public void Create<T>(T obj);
        public List<T> All<T>();

    }
}