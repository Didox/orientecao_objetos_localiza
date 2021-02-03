using System;
using System.Collections.Generic;
using Database;

namespace Negocio
{
    public class CarroService
    {
      /*  public static void Salvar<T>(T carro)
        {
            DBServiceGenerics.Salvar(carro);
            Console.WriteLine("Estou salvando o carro (com generics).");
        }

        public static List<T> Todos<T>(){
            return DBServiceGenerics.Todos<T>();
        }*/

         public static List<Carro> Todos()
        {
            var carros = DbServiceGenerics.Todos<Carro>();
            foreach(var carro in carros)
            {
                carro.Nome += "- Siena";
            }
            return carros;
        }
    }
}
