using System;
using System.Collections.Generic;

namespace Michele.Models {
  public class Client {
    private string name;
    public int Id {get; set;}
    public string Name { 
        get
        {
          return name;
        } 
        set
        {
          this.name = value.ToUpper();
        }
    }
    public string Address { get; set; }
    public DateTime BirthDay { get; set;}

    public override string ToString()
    {
      return $"O nome do cliente é {Name}, nasci em {BirthDay}, moro no endereço {Address}.";
    }

    public static void Save () {
      Console.WriteLine("Cliente Salvo com Sucesso!!");
    }

     public static List<Client> SearchName (string name = "") {
      var clients = new List<Client>();
      return clients;
    }

  }
}