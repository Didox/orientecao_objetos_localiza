using Negocio;
using System;
using Negocio;

namespace AppOrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new CarroServico();
            carro.Salvar(new Carro()
            {
                Id = 132,
                Descricao = "Teste Classe",
                Cor = "Prata",
                Ano = 2012
            });

            Console.WriteLine("Hello World!");
        }
    }
}
