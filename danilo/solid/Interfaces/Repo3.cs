using System;
using System.Collections.Generic;

namespace Interfaces
{
    public abstract class Repo3<T> where T : Repo<T>
    {
        public void Salvar()
        {
            Console.WriteLine("ok salvar");
        }

        public T Buscar()
        {
            List<T> lista = new List<T>();
            return (T)Convert.ChangeType(lista, typeof(T));
        }
    }
}
