using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class DBServicesGenerics
    {
        public static void Salvar<T>(T generico)
        {
            var sql = GenericMap.Builder(generico);

            Console.WriteLine(sql);
        }
    }
}
