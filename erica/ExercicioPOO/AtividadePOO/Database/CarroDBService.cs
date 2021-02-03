using System;
using System.Collections.Generic;
using System.Reflection;

namespace Database
{
    public class CarroDbService
    {
        public static void Salvar(IBase iBase)
        {
            var sql = Map.Builder(iBase);

            Console.WriteLine(sql);

        }

        public static List<Dado> Todos(Dado iBase){
            return new List<Dado>();
        }

    }
}
