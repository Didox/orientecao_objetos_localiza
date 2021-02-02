using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataBase
{
    class GenericMap
    {
        internal static string Builder<T>(T iBase)
        {
            var nomeTabela = iBase.GetType().Name.ToLower();
            var tabela = iBase.GetType().GetCustomAttribute<TabelaAttribute>();

            if (tabela != null && !string.IsNullOrEmpty(tabela.Nome))
            {
                nomeTabela = tabela.Nome;
            }
            var sql = $"insert into {nomeTabela} ( ";

            var campos = iBase.GetType().GetProperties();
            var camposTabela = new List<string>();

            foreach (var campo in campos)
            {
                var campoPersistir = campo.GetCustomAttribute<CampoPersisitidoAttribute>();
                if (campoPersistir != null)
                {
                    var nomeCampo = string.IsNullOrEmpty(campoPersistir.NomeColuna) ? campo.Name : campoPersistir.NomeColuna;
                    camposTabela.Add(nomeCampo);
                }
            }

            sql += string.Join(",", camposTabela);
            sql += ")";

            return sql;
        }
    }
}
