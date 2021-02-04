using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class PedidoProduto
    {

        public decimal Quantidade { get; set; }
        public Produto Produto { get; set; }

        public Pedido Pedido { get; set; }
    }
}
