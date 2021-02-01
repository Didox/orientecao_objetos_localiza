﻿using System;
using STRATEGY.Modelos.Implementado;

namespace STRATEGY
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new Fisica
            {
                Id = 1,
                Nome = "Danilo",
                Telefone = "3333333333",
                Cpf = "111111111111111"
            };

            var user2 = new Fisica
            {
                Id = 2,
                Nome = "Rodrigo",
                Telefone = "2222222",
                Cpf = "3333333333"
            };

            ClienteService.Cliente<Fisica>.Criar(user1);
            ClienteService.Cliente<Fisica>.Criar(user2);

            var lista = ClienteService.Cliente<Fisica>.ListaDeTodos();

            foreach (var cliente in lista)
            {
                Console.WriteLine(cliente.Nome);
            }


            

            
        }
    }
}
