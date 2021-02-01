using System;
using Database;

namespace Negocio
{
    public class CarroService
    {
        public static void Salvar<T>(T carro)
        {
            DBServiceGenerics.Salvar(carro);
            Console.WriteLine("Estou salvando o carro (com generics).");
            //CarroDbService.Salvar(carro);
        }

        public static List<T> Todos<T>(){
            return DBServiceGenerics.Todos<T>();
        }
    }
}
