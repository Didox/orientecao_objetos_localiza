using System;
using System.IO;
using mvc_scaffold.Models.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace mvc_scaffold.Models.Infraestrutura.Database
{
    public class ContextoLocaliza: DbContext
    {
        public ContextoLocaliza(DbContextOptions<ContextoLocaliza> options): base(options)
        {
        }

        public ContextoLocaliza(){ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            JToken jAppSettings = JToken.Parse(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "appsettings.json")));
            optionsBuilder.UseNpgsql(jAppSettings["ConexaoSql"].ToString());
        }
        
        public DbSet<Cliente> Clientes { get; set; }
    }
}
