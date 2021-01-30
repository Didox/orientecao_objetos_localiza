using System;
using System.Collections.Generic;
using System.Reflection;

namespace Database
{
    public class Map
    {
        public static string Builder(IBase iBase)
        {
            var nome = $"{iBase.GetType().Name.ToLower()}s";
            var tabela = iBase.GetType().GetCustomAttribute<TabelaAttribute>();
            if (tabela != null && !string.IsNullOrEmpty(tabela.Nome))
            {
                nome = tabela.Nome;
            }

            var campos = iBase.GetType().GetProperties();

            var sql = $"insert into {nome} values (";
            List<string> colunasDb = new List<string>();

            foreach (var campo in campos)
            {
                var campoPersistir = campo.GetCustomAttribute<CampoPersistidoAttribute>();
                if (campoPersistir != null)
                {
                    var nomeCampo = string.IsNullOrEmpty(campoPersistir.NomeColuna) ? campo.Name : campoPersistir.NomeColuna;

                    colunasDb.Add(nomeCampo);
                }
            }

            sql += string.Join(",", colunasDb.ToArray());

            return sql;
        }
    }
}