namespace NetCoreApi.Database.Interfaces
{
    public class SqlServerDBEnv : IDBEnv
    {
        public string GetConnectionString()
        {
            var host = System.Environment.GetEnvironmentVariable("SQL_SERVER_DB_HOST");
            var port = System.Environment.GetEnvironmentVariable("SQL_SERVER_DB_PORT");
            var database = System.Environment.GetEnvironmentVariable("SQL_SERVER_DB_DATABASE");
            var username = System.Environment.GetEnvironmentVariable("SQL_SERVER_DB_USERNAME");
            var password = System.Environment.GetEnvironmentVariable("SQL_SERVER_DB_PASSWORD");
            return $"Server={host},{port}; Database={database}; User Id={username}; Password={password}";
        }
    }
}
