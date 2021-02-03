using System;

namespace Megocio.Servicos.Provedores
{
    public class GatewayPagamento : IGatewayPagamento
    {
        public IServiceGatewayPagamento _servicoPagamento;

        public GatewayPagamento(IServiceGatewayPagamento servicoPagamento)
        {
            _servicoPagamento = servicoPagamento;
        }
        
        
        public void Pagar()
        {
            Console.WriteLine("Solicitando pagamento");
            _servicoPagamento.Pagar();
        }
    }
}