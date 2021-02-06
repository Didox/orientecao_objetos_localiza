using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCoreApi.Database.Interfaces;
using NetCoreApi.Database.Models;

namespace NetCoreApi.Database.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(new SqlServerDBEnv().GetConnectionString());
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
