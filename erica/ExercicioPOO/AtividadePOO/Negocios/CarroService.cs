using System;
using Database;

namespace Negocio
{
    public class CarroService
    {
        public static void Salvar(Carro carro)
        {
            //carro.Ano = 1;
            Console.WriteLine("Estou salvando o carro");

            CarroDbService.Salvar(carro);
        }
    }
}
