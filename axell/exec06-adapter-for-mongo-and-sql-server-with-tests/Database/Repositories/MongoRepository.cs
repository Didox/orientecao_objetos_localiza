using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using NetCoreApi.Database.Contexts;
using NetCoreApi.Database.Interfaces;

namespace NetCoreApi.Database.Repositories
{
    public class MongoRepository<T> : IBaseRepository<T> where T : IDocument
    {
        private readonly IMongoCollection<T> _collection;

        public MongoRepository()
        {
            var mongoDbEnv = new MongoDBEnv();
            var client = new MongoClient(mongoDbEnv.GetConnectionString());
            var database = client.GetDatabase(mongoDbEnv.Database);
            _collection = database.GetCollection<T>(typeof(T).Name);
        }

        public void Add(T entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(T entity)
        {
            var filter = Builders<T>.Filter.Eq(doc => doc.Id, entity.Id);
            _collection.FindOneAndReplace(filter, entity);
        }

        public void Delete(T entity)
        {
            var filter = Builders<T>.Filter.Eq(doc => doc.Id, entity.Id);
            _collection.FindOneAndDelete(filter);
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] expressions)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] expressions)
        {
            // var query = Builders<T>.Filter.Where(where);
            var query = _collection.AsQueryable<T>().Where(where);
            // foreach (var expression in expressions)
            // {
            //     query = query.Include(expression);
            // }
            return query.ToList();
        }
    }
}
