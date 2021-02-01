using System;
using System.Collections.Generic;

namespace Database
{
    public class CarroRepository
    {
        public static void Salvar<T>(T generic)
        {
            var campos = generic.GetType().GetProperties();

            var sql = $"insert into {generic.GetType().Name.ToLower()}s values (";

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

        public static List<T> ListarCarros<T>()
        {
            return new List<T>();
        }
        
        public static List<IBase> ListarCarros()
        {
            return new List<IBase>();
        }
    }
}