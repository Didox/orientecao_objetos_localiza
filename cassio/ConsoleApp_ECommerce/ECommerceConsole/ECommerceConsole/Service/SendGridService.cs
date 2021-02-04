using ECommerceConsole.Service;
using System;

namespace ECommerceConsole.Services
{
    public class SendGridService : IEmailService
    {
        public void Enviar(string telefone, string mensagem)
        {
            Console.WriteLine("Envia email...");
        }
    }
}
