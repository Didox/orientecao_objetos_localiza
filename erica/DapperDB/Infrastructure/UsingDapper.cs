using Dapper;
using System.Data.SqlClient;
using Z.Dapper.Plus;

namespace DapperDB.Infrastructure
{
    public class UsingDapper<T> : IDatabase<T> where T : class
    {
    public SqlConnectionDatabase(){
      this.connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
      }
    private string connectionString;
    public void Save(T obj){ //insere
      DapperPlusManager.Entity<T>().Table($"{obj.GetType().Name}s");
      using (var connection = new SqlConnection(connectionString)){
         connection.BulkInsert(new List<T>() { obj });
         }
    }

    public List<T> All(string sqlWhere = null){ //lista

    }
    public void Remove(T obj){ //deleta
    using (var connection = My.ConnectionFactory()){
    connection.Open();
    var isSuccess = connection.Delete(new Invoice {InvoiceID = $"{obj.GetType().GetProperties()}s"});
    }
    }
}
}