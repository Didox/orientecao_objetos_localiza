using ECommerceConsole.Models;

namespace ECommerceConsole.Repository
{
    public class EstoqueRepository : Repository<Estoque>
    {
        public bool VerificarEstoque(int idProduto)
        {
            return true;
        }

    }
}
