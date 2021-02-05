using BancoDeDados.Repositorios;
using Megocio.Servicos.Provedores;
using Negocio.Entidades;

namespace Megocio.Servicos
{
    public class PedidoService
    {
        private IRepositorioProvider _repositorioProvider;
        private IGatewayPagamento _gatewayPagamento;
        private IServicoEnviar _sms;
        private IServicoEnviar _mail;
        
        public PedidoService(IRepositorioProvider repositorioProvider, IGatewayPagamento gatewayPagamento, IServicoEnviar mail, IServicoEnviar sms)
        {
            _repositorioProvider = repositorioProvider;
            _gatewayPagamento = gatewayPagamento;
            _mail = mail;
            _sms = sms;
        }
        public void ProcessarPedido(Pedido pedido)
        {
            _repositorioProvider.Create(pedido);
            _gatewayPagamento.Pagar();
            _mail.Enviar();
            _sms.Enviar();
        }
    }
}