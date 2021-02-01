using System;
using System.Collections.Generic;

namespace Models.Implementations
{
    public class HomeServices
    {
        public static List<T> Index<T>(){
          return new List<T>();
        }

        public static void Save<T>(T data){
          Console.WriteLine($"Salvando na tabela {data.GetType().Name}");
        }
    }
}