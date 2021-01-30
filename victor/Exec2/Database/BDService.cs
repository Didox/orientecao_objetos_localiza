using System;
using System.Collections.Generic;

namespace Database
{
    public class BDService
    {
        public virtual void Salvar(Ibase iBase)
        {
            var campos = iBase.GetType().GetProperties();

            ICollection<string> colunas = new HashSet<string>();
            string query = $"insert into {iBase.GetType().Name} values (";

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
