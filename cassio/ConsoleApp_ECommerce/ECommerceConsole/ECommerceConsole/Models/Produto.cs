using System.Collections.Generic;

namespace ECommerceConsole.Models
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public ICollection<PedidoProduto> PedidoProdutos { get; set; } = new HashSet<PedidoProduto>();
    }
}
