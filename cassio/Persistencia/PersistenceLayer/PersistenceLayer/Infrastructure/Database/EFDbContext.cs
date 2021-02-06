using Microsoft.EntityFrameworkCore;
using PersistenceLayer.Models;

namespace PersistenceLayer.Infrastructure.Database
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=PersistenceLayerclass;User=sa;Password=Triangulo31@;");
        }

        public DbSet<Aula> Aulas { get; set; }
    }
}
