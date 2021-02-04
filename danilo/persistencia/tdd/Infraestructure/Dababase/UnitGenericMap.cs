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
        public int Id {get;set;}
        [Fields(ColumnName = "name")]
        public string Name {get;set;}

        [Fields(ColumnName = "phone")]
        public string Phone {get;set;}
    }
    
    public class UnitGenericMap
    {
        [Test]
        public void BuldGenericMap()
        {
            var sql = GenericMap.Builder(new Customer(){ Name = "Danilo" });
            Assert.AreEqual(sql, "insert into customers (name,phone) values (@name,@phone)");
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
    }
}