using ECommerceConsole.Models;
using ECommerceConsole.Repository;

namespace ECommerceConsole.Application
{
    public class ProdutoApp
    {
        private readonly ProdutoRepository _produtoRepository;
        private readonly EstoqueRepository _estoqueRepository;
        public ProdutoApp(ProdutoRepository produtoRepository, EstoqueRepository estoqueRepository)
        {
            _produtoRepository = produtoRepository;
            _estoqueRepository = estoqueRepository;
        }

        public void Cadastrar(Produto produto)
        {
            _produtoRepository.Salvar(produto);
        }

        public void VerificarEstoque(int idProduto)
        {
            _estoqueRepository.VerificarEstoque(idProduto);
        }

        public void ListarProdutos()
        {
            _produtoRepository.Listar();
        }

    }
}
