using System;
using singleton.Service;

namespace singleton.Models.UseCase
{
    public class UseCase
    {
        public static void Salvar<T>(T obj)
        {
            ClienteDbService.CriarInstancia().Salvar(obj);

            Console.WriteLine("Novo cliente Salvo utilizando Singleton");
        }
    }
}