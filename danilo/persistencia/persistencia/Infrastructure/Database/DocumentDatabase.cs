using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Newtonsoft.Json.Linq;

namespace Perfistencia.Infrastructure.Database
{
  public class DocumentDatabase<T> : IDatabase<T> where T : class
  {
    public DocumentDatabase()
    {
       this.connectionString = "mongodb://localhost:27017/localiza_document_db";
    }
    private string connectionString;

    private IMongoCollection<T> documento<T>()
    {
      IMongoClient client = new MongoClient(connectionString);
      var databaseName = connectionString.Split('/').Last();
      IMongoDatabase database = client.GetDatabase(databaseName);
      return database.GetCollection<T>((typeof(T)).Name);
    }

    public void Save(T obj)
    {
      documento<T>().InsertOne(obj);
    }

    public List<T> All()
    {
      return documento<T>().AsQueryable().ToList();
    }
    public void Remove(T obj)
    {
    }
  }
}