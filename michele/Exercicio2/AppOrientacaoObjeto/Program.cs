using Negocio;
using System;

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

            var grupoCliente = new GrupoCliente()
            {
                Nome = "Belo Horizonte"
            };
            NegocioService.Salvar(grupoCliente);

            Console.WriteLine("Hello World!");
        }
    }
}
