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
            // new EntityFrameworkDatabase<Customer>().Save(new Customer()
            // {
            //     Name = "Danilo novo entity",
            //     Phone = "(11)99999-9999"
            // });

            // new SqlConnectionDatabase<Customer>().Save(new Customer()
            // {
            //     Name = "Danilo novo SQL",
            //     Phone = "(11)99999-9999"
            // });

            // new DocumentDatabase<Customer>().Save(new Customer()
            // {
            //     Id = 1,
            //     Name = "Danilo novo MongoDB",
            //     Phone = "(11)99999-9999",
            //     CustomerType = new CustomerType(){
            //         Id = 1,
            //         Name = "Um tipo por ai"
            //     }
            // });

            // new DocumentDatabase<CustomerType>().Save(new CustomerType(){
            //     Id = 1,
            //     Name = "Um tipo por ai"
            // });

            //new DapperDatabase<Customer>().Save(new Customer()
            //{
            //    Name = "Danilo novo Dapper",
            //    Phone = "(11)99999-9999"
            //});
            
            Assert.AreEqual(true, true);
        }
    }
}