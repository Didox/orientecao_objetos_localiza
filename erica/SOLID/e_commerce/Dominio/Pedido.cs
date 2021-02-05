namespace e_commerce
{
    public class Pedido
    {
        public int id {get;set;}
        public double valorTotal {get;set;}
        public PedidoProdutos pedidoProdutos;
    }
}