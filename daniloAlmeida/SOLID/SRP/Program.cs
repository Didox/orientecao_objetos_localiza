using System;
using SRP.Solucao;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente(){
                Id = 3,
                Nome = "Danilo"
            };

            Repositorio.Salvar(cliente);            
        }
    }
}
