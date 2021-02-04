using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using NUnit.Framework;
using Perfistencia.Domain.Entities;
using Perfistencia.Infrastructure.Database;

namespace tdd
{
    record CustomerRecord
    {
        public string Name {get;set;}
    }

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

            // new SqlConnectionDatabase<Customer>().Update(new Customer()
            // {
            //     Id = 2,
            //     Name = "Danilo atualizado",
            //     Phone = "(11)99999-9999"
            // });

            // new SqlConnectionDatabase<Customer>().Remove(new Customer()
            // {
            //     Id = 8,
            // });

            var customerSql = new SqlConnectionDatabase<Customer>();
            customerSql.SqlCommand("truncate table customers");

            customerSql.Save(new Customer()
            {
                Name = "Danilo novo SQL",
                Phone = "(11)99999-9999"
            });

            var customers = customerSql.All();
            
            Assert.AreEqual(customers.Count, 1);
            Assert.AreEqual(customers.First().Id, 1);
            Assert.AreEqual(customers.First().Name, "Danilo novo SQL");
            Assert.AreEqual(customerSql.All("where name like '%Danilo%'").First().Name, "Danilo novo SQL");
            Assert.AreEqual(customerSql.All("where name = 'Danilo'").Count, 0);

            List<DbParameter> parameters = new List<DbParameter>();
            var parameterNome = new SqlParameter("@name", System.Data.SqlDbType.VarChar);
            parameterNome.Value = "Danilo";
            parameters.Add(parameterNome);

            var parameterPhone = new SqlParameter("@phone", System.Data.SqlDbType.VarChar);
            parameterPhone.Value = "(11)99999-9999";
            parameters.Add(parameterPhone);

            var customerProcedure = customerSql.AllByPrecedure("sp_selectCustomers", parameters);
            Assert.AreEqual(customerProcedure.Count, 0);

            var customerRecords = new SqlConnectionDatabase<CustomerRecord>().AllByPrecedure("sp_selectCustomersOnlyName");
            Assert.AreEqual(customerRecords.Count > 0, true);
            Assert.AreEqual(customerRecords[0].Name != null, true);
        }
    }
}