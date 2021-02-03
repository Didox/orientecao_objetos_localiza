using System;
using System.Collections.Generic;

namespace strategy.Modelos.Implementado
{
    public class ClienteService
    {
    public static void Salvar(IPessoa pessoa){
      Console.WriteLine($"Salvando na tablea do tipo {pessoa.GetType().Name}");
    }
    public static List<IPessoa> Todos() {
      return new List<IPessoa>();
    }

    public static List<T> Todos<T>(){
      return new List<T>();
    }
        
    }
}