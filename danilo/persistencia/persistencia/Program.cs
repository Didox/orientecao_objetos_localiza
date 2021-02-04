using System;
using Perfistencia.Domain.Entities;
using Perfistencia.Infrastructure.Database;

namespace persistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            new EntityFrameworkDatabase<Customer>().Save(new Customer()
            {
                Name = "Danilo novo Dapper",
                Phone = "(11)99999-9999"
            });
        }
    }
}
