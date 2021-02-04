using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceConsole.Models
{
    public class PedidoProduto : EntidadeBase
    {
        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }

        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }

    }
}
