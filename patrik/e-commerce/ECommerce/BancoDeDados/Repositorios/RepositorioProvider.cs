using System;
using System.Collections.Generic;

namespace BancoDeDados.Repositorios
{
    public class RepositorioProvider : IRepositorioProvider
    {
        public void Create<T>(T obj)
        {
            Console.WriteLine("Create");
        }

        public List<T> All<T>()
        {
            return new List<T>();
        }

    }
}