using System;
using Michele.Models;

namespace Michele
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client("Michele", "Ribeiro"){
                Address =  "Romoaldo Lopes Cançado, 224",
                Id = 123456,
                Tipo = TipoCliente.Basic
            };
            var clientSearch = Client.SearchName("Michele de Freitas Ribeiro");
            Client.Save();
            client.WriteDisplay();


            Console.WriteLine(client);
        }
    }
}
