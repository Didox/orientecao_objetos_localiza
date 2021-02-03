using System;

namespace SRP.Quebra
{
    public class Client
    {
        
        public int Id {get; set; }
        public string Name {get; set; }
        public string Adress { get; set; }

        public void Create(Client client){
            Console.WriteLine($"Criando Cliente {client.Name}");
        }

        public void Save(Client client){
            Console.WriteLine($"Salvando Cliente {client.Name}");
        }

        public void SendEmail(string email){
            Console.WriteLine($"Enviando e-mail {email}");
        }

        public void SendSms(string sms){
            Console.WriteLine($"Enviando SMS {sms}");
        }

    }
}