using ECommerceConsole.Models;
using System;

namespace ECommerceConsole.Service
{
    public class TxtService : IArquivoService
    {
        public void Salvar(Pedido pedido)
        {
            Console.WriteLine("Salvando em formato TXT");
        }
    }
}
