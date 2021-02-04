using System;
using Negocio;

namespace hugo
{
    class Program
    {
        static void Main(string[] args)
        {
           
           var carro = new CarroService();
            carro.Salvar(new Carro()
            {
                Id = 1,
                Descricao = "Carro 1",
                Ano = 2021
            });
        }
    }
}