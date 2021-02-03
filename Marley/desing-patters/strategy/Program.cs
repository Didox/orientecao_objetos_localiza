using System;
using Strategy.Models.Strategy1;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client()
            {
                Name = "Marley";
                Phone = "31-121321",
                Email = "teste@gemail.com",
                Tipo =   ClientType.Fisica;          }
        }
    }
}
