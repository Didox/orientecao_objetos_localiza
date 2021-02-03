using ECommerceConsole.Models;
using System;

namespace ECommerceConsole.Service
{
    class PagamentoCieloService : IPagamentoService
    {
        public bool Pagar(Pedido pedido)
        {
            Console.WriteLine("Pagando com a Cielo...");
            return true;
        }
    }
}
