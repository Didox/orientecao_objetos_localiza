using System;
using System.Collections.Generic;

namespace Database
{
    public class BDService
    {
        ICollection<string> colunas = new HashSet<string>();

        public virtual void Salvar<T>(T generico)
        {
            var tipo = generico.GetType();
            var campos = tipo.GetProperties();

            string query = $"insert into {generico.GetType().Name} values (";

            foreach (var campo in campos)
            {
                colunas.Add(campo.Name);
            }

            query += string.Join(",", colunas);
            query += ")";

            Console.WriteLine(query);
        }


        public virtual List<object> Listar()
        {
            // lista buscada do banco
            return new List<object>();
        }

    }
}
