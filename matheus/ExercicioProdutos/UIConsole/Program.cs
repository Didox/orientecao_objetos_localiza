using Negocio;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [ SIMULAÇÃO - PREENCHIMENTO DE OBJETO ]

            Produto produto = new Produto()
            {
                Id = 1, //Apenas simulação
                Nome = "Arroz"
            };

            Cliente cliente = new Cliente()
            {
                Id = 1, //Apenas simulação
                Nome = "Matheus"
            };

            Pedido pedido = new Pedido()
            {
                Registro = DateTime.Now,
                Cliente = cliente

            };
            PedidoProduto pedidoProduto = new PedidoProduto()
            {
                Produto = produto,
                Pedido = pedido,
                Quantidade = 2
            };

            #endregion

            if (NegocioService.Salvar(pedido))
            {
                EmailService.Enviar(pedido);
                SmsService.Enviar(pedido);
                PagamentoService.Pagar(pedido);
            }

        }
    }
}
