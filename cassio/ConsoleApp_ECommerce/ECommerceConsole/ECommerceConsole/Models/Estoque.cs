using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceConsole.Models
{
    public class Estoque : EntidadeBase
    {
        public int Quantidade { get; set; }

        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }

    }
}
