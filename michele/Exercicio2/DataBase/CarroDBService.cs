using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataBase
{
    public class CarroDBService
    {
        public static void Salvar(IBase carro)
        {
            var sql = Map.Builder(carro);
            Console.WriteLine(sql);
        }
    }
}
