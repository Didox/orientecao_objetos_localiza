using System; 
using Database.Repositories.ClientRepository;
using Business.Modules.Client.Entities;

namespace Business.Modules.Client.UseCases
{
    public class ClienteCreate
    {

        public void Create(IClient client, IClientRepository clientRepository){
            var newClient = clientRepository.Create(client);
            Console.WriteLine($"Salvando usuário {client.Id}.");
        }
        
    }
}