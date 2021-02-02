using System;
using System.Collections.Generic;
using System.Reflection;

namespace Database
{
    public class DbServiceGenerics
    {
        public static void Salvar<T>(T dado)
        {
            var sql = GenericMap.Builder(dado);

            Console.WriteLine(sql);

        }

        public static List<T> Todos<T>()
        {
            return null;
        }
    }
}
