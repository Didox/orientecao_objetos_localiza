using ECommerceConsole.Models;
using ECommerceConsole.Repository;

namespace ECommerceConsole.Application
{
    public class ClienteApp
    {
        private readonly ClienteRepository _clienteRepository;
        public ClienteApp(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Cadastrar(Cliente cliente)
        {
            _clienteRepository.Salvar(cliente);
        }
    }
}
