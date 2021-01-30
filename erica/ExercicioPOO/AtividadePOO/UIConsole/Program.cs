using System;
using Negocios;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new Carro()
            {
                Id = 1,
                Nome = "Uno",
                //Telefone = "12222",
                Ano = 2021,
                Descricao = "Um teste"
            }.Salvar();
        }
    }
}
