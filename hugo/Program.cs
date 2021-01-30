using System;
using hugo.Modelos;

namespace hugo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var cliente = new Cliente()
            {
                Id= 1,
                Nome = "Hugo"
            };

            cliente.exibeNomeNaTela();
        }
    }
}
