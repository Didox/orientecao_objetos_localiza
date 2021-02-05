using Dapper;
using System.Data.SqlClient;
using Z.Dapper.Plus;

namespace DapperDB.Infrastructure
{
    public class UsingDapper<T> : IDatabase<T> where T : class
    {
    public SqlConnectionDatabase(){
      this.connectionString = "Server=localhost;Database=exemploDapper;Uid=sa;Pwd=";
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
      throw new Exception("Falta fazer");
    }
    public void Remove(T obj)
    {
      throw new Exception("Falta fazer");
    }
    }
}