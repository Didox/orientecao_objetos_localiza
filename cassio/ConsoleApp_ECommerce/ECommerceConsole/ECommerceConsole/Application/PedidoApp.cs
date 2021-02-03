using ECommerceConsole.Models;
using ECommerceConsole.Repository;
using ECommerceConsole.Service;

namespace ECommerceConsole.Application
{
    public class PedidoApp
    {
        private readonly PedidoRepository _pedidoRepository;
        private readonly ISmsService _smsService;
        private readonly IEmailService _emailService;
        private readonly IPagamentoService _pagamentoService;
        private readonly IArquivoService _arquivoService;

        public PedidoApp(PedidoRepository pedidoRepository,
            ISmsService smsService,
            IEmailService emailService,
            IPagamentoService pagamentoService,
            IArquivoService arquivoService)
        {
            _pedidoRepository = pedidoRepository;
            _smsService = smsService;
            _emailService = emailService;
            _pagamentoService = pagamentoService;
            _arquivoService = arquivoService;
        }

        public void CriarPedido(Pedido pedido)
        {
            _arquivoService.Salvar(pedido);
            _pedidoRepository.Salvar(pedido);
            _smsService.Enviar(pedido.Cliente.Email, $"Seu pedido {pedido.NumeroPedido} foi criado com sucesso!");
            _emailService.Enviar(pedido.Cliente.Email, $"Seu pedido {pedido.NumeroPedido} foi criado com sucesso!");
            _pagamentoService.Pagar(pedido);
        }
    }
}
