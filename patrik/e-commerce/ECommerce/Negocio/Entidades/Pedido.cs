using System;
using System.Collections.Generic;

namespace Negocio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Date { get; set; }
        public List<Produto> Produtos { get; set; }

        public float Total
        {
            get
            {
                float total = 0;
                foreach (var produto in Produtos)
                {
                    total += produto.Preco;
                }

                return total;
            }
            private set { }
        }
    }
}