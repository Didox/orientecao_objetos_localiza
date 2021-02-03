using System.Collections.Generic;

namespace ECommerceConsole.Models
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } = new HashSet<Pedido>();
    }
}
