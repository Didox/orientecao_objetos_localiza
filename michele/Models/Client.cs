using System;
using System.Collections.Generic;

namespace Michele.Models {

  public class Client: Person
  {

    //Constantes são declaradas com todas as letras em maiusculos.
    public const int BASIC = 1;
    public const int PREMIUM = 2;

    public TipoCliente Tipo { get; set; }

    public Client() 
    {
      
    }  

    public Client(string name, string surname) : base(name, surname)
    {
      
    }   

    public string Address { get; set; }

    public DateTime BirthDay { get; set;}

    public override string ToString()
    {
      return $"O nome do cliente é {Name}, nasci em {BirthDay}, moro no endereço {Address}, tipo cliente é {Tipo}.";
    }

    public static void Save () {
      Console.WriteLine("Cliente Salvo com Sucesso!!");
    }

    public static List<Client> SearchName (string name = "") {
      var clients = new List<Client>();
      return clients;
    }

    public override void WriteDisplay (){
      Console.WriteLine("Metodo Filho");
      base.WriteDisplay();
    }

  }
}