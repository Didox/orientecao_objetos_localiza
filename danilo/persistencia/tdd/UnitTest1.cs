using NUnit.Framework;
using Perfistencia.Domain.Entities;
using Perfistencia.Infrastructure.Database;

namespace tdd
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InvertCustomerOnDatabase()
        {
            new EntityFrameworkDatabase<Customer>().Save(new Customer()
            {
                Name = "Danilo novo entity",
                Phone = "(11)99999-9999"
            });

            new SqlConnectionDatabase<Customer>().Save(new Customer()
            {
                Name = "Danilo novo SQL",
                Phone = "(11)99999-9999"
            });

            Assert.AreEqual(true, true);
        }
    }
}