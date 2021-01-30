using System;
using Negocios;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new CarroService();
            carro.Salvar(new Carro()
            {
                id = 1,
                modelo = "Uno",
                Ano = 2000
            });
        }
    }
}
