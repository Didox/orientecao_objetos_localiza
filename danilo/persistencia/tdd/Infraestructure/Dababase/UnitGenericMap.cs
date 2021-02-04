using System;
using System.Collections.Generic;
using System.Reflection;
using Perfistencia.Infrastructure.Database;
using NUnit.Framework;
using System.Data;

namespace Tdd.Infrastructure.Database
{
    public class Customer
    {
        [Pk(Name = "id")]
        public int Id {get;set;}
        [Fields(ColumnName = "name")]
        public string Name {get;set;}

        [Fields(ColumnName = "phone")]
        public string Phone {get;set;}
    }
    
    public class UnitGenericMap
    {
        [Test]
        public void BuldGenericMapInsert()
        {
            var sql = GenericMap.BuilderInsert(new Customer(){ Name = "Danilo" });
            Assert.AreEqual(sql, "insert into customers (name) values (@name)");
        }

        [Test]
        public void BuldGenericMapDelete()
        {
            var sql = GenericMap.BuilderDelete(new Customer(){ Id = 1 });
            Assert.AreEqual(sql, "delete from customers where id=1");
        }

        [Test]
        public void BuldGenericMapSelect()
        {
            var sql = GenericMap.BuilderSelect<Customer>();
            Assert.AreEqual(sql, "select customers.* from customers");
        }

        [Test]
        public void BuldGenericMapSelectWhere()
        {
            var sql = GenericMap.BuilderSelect<Customer>("where nome like '%Danilo%'");
            Assert.AreEqual(sql, "select customers.* from customers where nome like '%Danilo%'");
        }

        [Test]
        public void BuldGenericMapUpdate()
        {
            var sql = GenericMap.BuilderUpdate(new Customer(){ Id = 1, Name = "Danilo" });
            Assert.AreEqual(sql, "update customers set name=@name where id=@id");
        }

        [Test]
        public void BuldGenericMapParameter()
        {
            var parameters = GenericMap.BuilderParameters(new Customer(){ Name = "Danilo", Phone = "(11)99999-9999" });
            Assert.AreEqual(parameters.Count, 2);

            Assert.AreEqual(parameters[0].ParameterName, "@name");
            Assert.AreEqual(parameters[0].SqlDbType, SqlDbType.VarChar);

            Assert.AreEqual(parameters[1].ParameterName, "@phone");
            Assert.AreEqual(parameters[1].SqlDbType, SqlDbType.VarChar);
        }

        [Test]
        public void BuldGenericMapParameterNull()
        {
            var parameters = GenericMap.BuilderParameters(new Customer(){ Name = "Danilo", Phone = null });
            Assert.AreEqual(parameters.Count, 1);

            Assert.AreEqual(parameters[0].ParameterName, "@name");
            Assert.AreEqual(parameters[0].SqlDbType, SqlDbType.VarChar);
        }
    }
}