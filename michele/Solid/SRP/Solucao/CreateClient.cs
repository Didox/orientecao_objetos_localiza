using System;

namespace SRP.Solucao
{
    public class CreateClient
    {
        public void Create(Client client){
            Console.WriteLine($"Criando Cliente {client.Name}");
        }
    }
}