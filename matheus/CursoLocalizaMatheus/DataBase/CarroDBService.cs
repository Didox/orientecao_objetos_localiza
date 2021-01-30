using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class CarroDBService
    {

        public static void Salvar(IBase iBase)
        {
            var campos = iBase.GetType().GetProperties();

            var sql = $"insert into " + iBase.GetType().Name + " values (";
            List<string> colunasDB = new List<string>();

            foreach(var campo in campos)
            {
                colunasDB.Add(campo.Name);
            }

            sql += string.Join("", colunasDB.ToArray());

            sql += ")";

            Console.WriteLine(sql);
    
        }

    }
}
