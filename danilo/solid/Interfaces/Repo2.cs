using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Repo
    {
        public Repo()
        {
        }

        public void Salvar()
        {
            Console.WriteLine("ok salvar");
        }

        public static T BuscaPorNome<T>(string nome)
        {
            List<ICarro> lista = new List<ICarro>();
            return (T)Convert.ChangeType(lista, typeof(T));
        }
    }
}
