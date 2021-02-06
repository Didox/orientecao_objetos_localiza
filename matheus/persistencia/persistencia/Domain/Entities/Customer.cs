using System;
using System.Collections.Generic;
using Perfistencia.Infrastructure.Database;

namespace Perfistencia.Domain.Entities
{
  [Table(Name = "Customers")]
  public class Customer
  {
    [Pk(Name= "id")]
    public int Id {get;set;}
    [Fields(ColumnName = "name")]
    public string Name {get;set;}

    [Fields(ColumnName = "phone")]
    public string Phone {get;set;}

    public CustomerType CustomerType {get;set;}
  }
}