using System;
using System.Collections.Generic;

namespace Database
{
    public class BDService
    {
       

        public virtual void Salvar<T>(T generico)
        {
            var tipo = generico.GetType();
            var campos = tipo.GetProperties();

            string query = $"insert into {generico.GetType().Name} values (";
            ICollection<string> colunas = new HashSet<string>();

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
