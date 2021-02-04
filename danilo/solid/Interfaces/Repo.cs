using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Repo<T>
    {
        public Repo()
        {
        }

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
