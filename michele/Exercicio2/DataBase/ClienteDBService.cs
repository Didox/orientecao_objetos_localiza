using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class ClienteDBService 
    {

        public static void Salvar(IBase cliente)
        {
            var sql = Map.Builder(cliente);
            Console.WriteLine(sql);
        }
    }
}
