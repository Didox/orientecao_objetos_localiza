using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces.SOLID.SRP.SolucaoComBaseSRP
{
    public class RepositorioQuery : IRepositorioQuery
    {
        public int Executa(string sql)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaStrConnection";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
