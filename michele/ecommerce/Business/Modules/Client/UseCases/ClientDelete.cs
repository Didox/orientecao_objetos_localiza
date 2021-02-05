using System; 
using Database.Repositories.ClientRepository;

namespace Business.Modules.Client.UseCases
{
    public class ClientDelete
    {

        public void Delete<IClient>(IClient obj, IClientRepository clientRepository){
            clientRepository.Delete(obj);
            Console.WriteLine($"Excluindo usuário.");
        }
    }
}