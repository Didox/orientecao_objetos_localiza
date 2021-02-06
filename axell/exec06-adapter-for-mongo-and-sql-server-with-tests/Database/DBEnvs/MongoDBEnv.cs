using System;

namespace NetCoreApi.Database.Interfaces
{
    public class MongoDBEnv : IDBEnv
    {
        public string Database { get; set; }

        public MongoDBEnv()
        {
            Database = System.Environment.GetEnvironmentVariable("MONGO_DB_DATABASE");
        }

        public string GetConnectionString()
        {
            var host = System.Environment.GetEnvironmentVariable("MONGO_DB_HOST");
            var port = System.Environment.GetEnvironmentVariable("MONGO_DB_PORT");
            var username = System.Environment.GetEnvironmentVariable("MONGO_DB_USERNAME");
            var password = System.Environment.GetEnvironmentVariable("MONGO_DB_PASSWORD");
            return $"mongodb://{username}:{password}@{host}:{port}/{Database}?authSource=admin";
        }
    }
}
