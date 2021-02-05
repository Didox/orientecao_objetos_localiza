using System;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using Dapper;
using Z.Dapper.Plus;
using Perfistencia.Domain.Entities;

namespace Perfistencia.Infrastructure.Database
{
    public class DapperDatabase<T> : IDatabase<T> where T : class
    {
        public DapperDatabase()
        {
            this.connectionString = "Server=localhost;Database=localiza_test_persistencia;Uid=sa;Pwd=!1#2a3d4c5g6v";
        }
        private string connectionString;

        public void Save(T obj)
        {
            DapperPlusManager.Entity<T>().Table($"{obj.GetType().Name}s");

            using (var connection = new SqlConnection(connectionString))
            {
                connection.BulkInsert(new List<T>() { obj });
            }

            // var context = new EntityContext();
            // var dbSet = context.Set<T>();
            // dbSet.Add(obj);
            // context.SaveChanges();
        }

        public List<T> All(string sqlWhere = null)
        {
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var reader = connection.ExecuteReader("SELECT * FROM Customers;");
            //}

            throw new Exception("Falta fazer");
        }
        public void Remove(T obj)
        {
            throw new Exception("Falta fazer");
        }
    }
}