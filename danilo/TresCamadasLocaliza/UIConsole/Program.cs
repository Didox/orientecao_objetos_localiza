using System;
using Negocio;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarroService.Salvar(new Carro()
            //{
            //    Id = 1,
            //    Nome = "Danilo",
            //    Telefone = "12222",
            //    Ano = 2021,
            //    Descricao = "Um teste"
            //});

            new Carro()
            {
                Id = 1,
                Nome = "Danilo",
                Telefone = "12222",
                Ano = 2021,
                Descricao = "Um teste"
            }.Salvar();
        }
    }
}
