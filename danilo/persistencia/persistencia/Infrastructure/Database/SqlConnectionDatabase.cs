using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Perfistencia.Infrastructure.Database
{
  public class SqlConnectionDatabase<T> : IDatabase<T> where T : class
  {
    public SqlConnectionDatabase()
    {
      this.connectionString = "Server=localhost;Database=localiza_test_persistencia;Uid=sa;Pwd=!1#2a3d4c5g6v";
    }
    private string connectionString;
    public void Save(T obj){

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        var queryString = GenericMap.Builder(obj);
        SqlCommand command = new SqlCommand(queryString, connection);
        var parameters = GenericMap.BuilderParameters(obj);
        foreach(var parameter in parameters)
        {
          command.Parameters.Add(parameter);
        }
        command.Connection.Open();
        command.ExecuteNonQuery();
      }
    }

    public List<T> All(){
      throw new Exception("Falta fazer");
    }
    public void Remove(T obj){
      throw new Exception("Falta fazer");
    }
  }
}