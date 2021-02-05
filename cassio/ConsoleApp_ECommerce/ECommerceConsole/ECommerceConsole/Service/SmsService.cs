using System;

namespace ECommerceConsole.Service
{
    public class SmsService : ISmsService
    {
        public void Enviar(string telefone, string mensagem)
        {
            Console.WriteLine("Enviado sms...");
        }
    }
}
