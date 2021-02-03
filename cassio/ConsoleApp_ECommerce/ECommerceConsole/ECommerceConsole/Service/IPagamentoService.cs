using ECommerceConsole.Models;

namespace ECommerceConsole.Service
{
    public interface IPagamentoService
    {
        bool Pagar(Pedido pedido);
    }
}
