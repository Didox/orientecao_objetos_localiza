using ECommerceConsole.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceConsole.Models
{
    public class Pedido : EntidadeBase
    {
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int NumeroPedido { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public ICollection<PedidoProduto> PedidoProdutos { get; set; } = new HashSet<PedidoProduto>();
    }
}
