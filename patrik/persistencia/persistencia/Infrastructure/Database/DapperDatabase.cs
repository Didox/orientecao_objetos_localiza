using System;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using Dapper;
using Microsoft.VisualBasic;
using Z.Dapper.Plus;
using Perfistencia.Domain.Entities;

namespace Perfistencia.Infrastructure.Database
{
  public class DapperDatabase<T> : IDatabase<T> where T : class
  {
    public DapperDatabase()
    {
       this.connectionString = "Server=localhost;Database=localiza_test_persistencia;Uid=sa;Pwd=D0cker@D0cker";
    }
    private string connectionString;

    public void Save(T obj)
    {
      DapperPlusManager.Entity<T>().Table($"{obj.GetType().Name}s");
      
      using (var connection = new SqlConnection(connectionString))
      {
         connection.BulkInsert(new List<T>() { obj });
      }
    }

    public List<T> All(string sqlWhere = null)
    {
      var dado = Activator.CreateInstance<T>();

      using (var connection = new SqlConnection(connectionString))
      {
        return connection.Query<T>($"SELECT * FROM {dado.GetType().Name}s {sqlWhere}").ToList();
      }
    }
    public void Remove(T obj)
    {
      using (var connection = new SqlConnection(connectionString))
      {
        PropertyInfo pkProperty = null;
        foreach (var p in obj.GetType().GetProperties())
        {
          var pkAttr = p.GetCustomAttribute<PkAttribute>();
          if (pkAttr != null)
          {
            pkProperty = p;
            break;
          }
        }
        
        var pk = pkProperty.GetCustomAttribute<PkAttribute>();
        var value = Convert.ToInt32(pkProperty.GetValue(obj));
        connection.BulkDelete(connection.Query<T>($"SELECT * FROM {obj.GetType().Name}s WHERE {pk.Name}={value}").ToList());
      }
    }
  }
}