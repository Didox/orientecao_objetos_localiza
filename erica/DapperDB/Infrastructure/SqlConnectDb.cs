using System.Data.Common;
using System.Data.SqlClient;

namespace DapperDB.Infrastructure
{
    public class SqlConnectDb<T> : IDatabase<T> where T : class
    {
    public SqlConnectionDatabase(){
      this.connectionString = "Server=localhost;Database=exemploDapper;Uid=sa;Pwd=";
      }

    private string connectionString;
    public void Save(T obj){ //inserindo
      using (SqlConnection connection = new SqlConnection(connectionString)){
        var queryString = GenericMap.BuilderInsert(obj);
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

    public List<T> All(string SqlWhere = null){ //select *
      var list = new List<T>();
      using (SqlConnection connection = new SqlConnection(connectionString)){
        var queryString = GenericMap.BuilderSelect<T>(SqlWhere);
        SqlCommand command = new SqlCommand(queryString, connection);
        command.CommandType = System.Data.CommandType.Text;
        command.Connection.Open();

        using (SqlDataReader dr = command.ExecuteReader()){
          while (dr.Read()){
            var instance = Activator.CreateInstance(typeof(T));
            this.fill(instance, dr);
            list.Add((T)instance);
          }
        }
      }
      return list;
    }

    public void Update(T obj){ //alterando
      using (SqlConnection connection = new SqlConnection(connectionString)){
        var queryString = GenericMap.BuilderUpdate(obj);
        SqlCommand command = new SqlCommand(queryString, connection);
        var parameters = GenericMap.BuilderParameters(obj, true);

        foreach(var parameter in parameters)
        {
          command.Parameters.Add(parameter);
        }

        command.Connection.Open();
        command.ExecuteNonQuery();
      }
    }

    private void fill(object modelo, SqlDataReader dr){
        foreach (var p in modelo.GetType().GetProperties()){
            try{
                if (dr[p.Name] == DBNull.Value) continue;
                p.SetValue(modelo, dr[p.Name]);
            }
            catch { }
            }
        }

    public void Remove(T obj){ //delete
      using (SqlConnection connection = new SqlConnection(connectionString)){
        var queryString = GenericMap.BuilderDelete(obj);
        SqlCommand command = new SqlCommand(queryString, connection);
        command.Connection.Open();
        command.ExecuteNonQuery();
      }
    }

}
}