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
      DapperPlusManager.Entity<T>().Table($"{obj.GetType().Name}s"); //esse utiliza dapper plus
      using (var connection = new SqlConnection(connectionString)){
         connection.BulkInsert(new List<T>() { obj });
         }
    }

    public List<T> All(string sqlWhere = null){ //lista todos - esse utiliza dapper contrib
        using (var connection = My.ConnectionFactory()){
        connection.Open();
        var costumers = connection.GetAll<Invoice>().ToList();
        }
    }

   public List<T> Get(string sqlWhere = null){ //lista 1
   using (var connection = My.ConnectionFactory()){
        connection.Open();
        var customer = connection.Get<Customer>(1);
        }
    }

    public void Remove(T obj){ //deleta 1
        using (var connection = My.ConnectionFactory()){
        connection.Open();
        var isSuccess = connection.Delete(new Customer {id = $"{obj.GetType().GetProperties()}s"});
        }
    }
}
}