using System;
using Negocio;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var carroService = new CarroService();
            var carro = new Carro();
            
            carro.Id = "d0eeb7b6-545a-4a3b-a6ce-eb7ec6ad566a";
            carro.Marca = "Volkswagen";
            carro.Modelo = "Virtus";
            
            carroService.Salvar(carro);
        }
    }
}