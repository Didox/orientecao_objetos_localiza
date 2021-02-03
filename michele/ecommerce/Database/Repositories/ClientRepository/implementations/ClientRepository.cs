using System;

namespace Database.Repositories.ClientRepository.implementations
{
    public class ClientRepository : IClientRepository
    {
        
        public T Create<T>(T client)        
        {
            var newClient = BaseRepository.Create(client);
            return newClient;
        }
        public void Delete<T>(T obj)
        {
            BaseRepository.Delete(obj);
            Console.WriteLine("Deletando cliente.");
        }
    }
}