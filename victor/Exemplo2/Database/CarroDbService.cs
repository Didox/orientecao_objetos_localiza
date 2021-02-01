using System;
using System.Collections.Generic;

namespace Database
{
    public class CarroDbService
    {
        // Implementando Generics
        public static void Salvar<T>(T generic)
        {
            var tipo = generic.GetType();
            var campos = generic.GetType().GetProperties();

            string query = $"insert into {tipo.Name} values (";
            ICollection<string> colunas = new HashSet<string>();

            foreach (var campo in campos)
            {
                colunas.Add(campo.Name);
            }

            query += string.Join(",", colunas);
            query += ")";

            Console.WriteLine(query);
        }

    }
}
