using System;
using DataBase;

namespace Negocio
{
    public class CarrosService
    {
        public static void Salvar(Carro carro){
            Console.WriteLine("Estou salvando o carro");
            CarroDbServices.Salvar(carro);
        }        
    }
}