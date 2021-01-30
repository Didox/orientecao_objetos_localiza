using System;
using System.Collections.Generic;

namespace Database
{
    public class CarroService
    {
        public static void Salvar(IBase iBase)
        {
            var campos = iBase.GetType().GetProperties();

            var sql = $"insert into {iBase.GetType().Name.ToLower()}s values (";

            List<string> colunasDb = new List<string>();

            foreach (var campo in campos)
            {
                if (campo.Name.ToLower() != "id")
                {
                    colunasDb.Add(campo.Name);
                }
            }

            sql += string.Join(",", colunasDb.ToArray());
            sql += ")";
            
            Console.WriteLine(sql);
        }
    }
}