using System;
using Microsoft.EntityFrameworkCore;
using Perfistencia.Domain.Entities;

namespace Perfistencia.Infrastructure.Database
{
  public class EntityContext : DbContext
  {
    public EntityContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=localhost;Database=localiza_test_persistencia;Uid=sa;Pwd=!1#2a3d4c5g6v");
    }

    public DbSet<Customer> Customers { get; set; }
  }
}