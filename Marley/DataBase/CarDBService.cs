using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class CarroDBService
    {

        public static void Save(IBase iBase)
        {
            var fields = iBase.GetType().GetProperties();

            var sql = $"insert into " + iBase.GetType().Name + " values (";
            List<string> collumnsDB = new List<string>();

            foreach (var campo in campos)
            {
                collumnsDB.Add(campo.Name);
            }

            sql += string.Join("", collumnsDB.ToArray());

            sql += ")";

            Console.WriteLine(sql);

        }

    }
}