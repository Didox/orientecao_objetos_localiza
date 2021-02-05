namespace Negocio.Entidades
{
    public class ProdutoPedido
    {
        public Pedido Pedido { get; set; }
        public Produto[] Produtos { get; set; }
    }
}