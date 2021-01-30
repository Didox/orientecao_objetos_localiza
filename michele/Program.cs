using System;
using Michele.Models;

namespace Michele
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Address= "Romoaldo Lopes Cançado, 224";
            client.BirthDay = new DateTime(1996,05,06);
            client.Name = "Michele de Freitas Ribeiro";
            client.Id = 123456;
            var clientSearch = Client.SearchName("Michele de Freitas Ribeiro");
            Client.Save();
            Console.WriteLine(client);
        }
    }
}
