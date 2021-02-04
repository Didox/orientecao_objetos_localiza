using Negocios;
using DataBase;
using System;

namespace UIConsole
{
    class Program
    {

        static void Main(string[] args)
        {

            var user1 = new Usuario
            {
                Id = 1,
                Nome = "Danilo",
                telefone = "3333333333"
            };

            var user2 = new Usuario
            {
                Id = 2,
                Nome = "Rodrigo",
                telefone = "2222222"
            };
            Contexto<Usuario>.Criar(user1);
            Contexto<Usuario>.Criar(user2);

            var lista = Contexto<Usuario>.ListaDeTodos();

            foreach (var usuario in lista)
            {
                Console.WriteLine(usuario.Nome);
            }

            Console.WriteLine(Contexto<Usuario>.BuscaPorNome("Danilo").telefone);

            Console.ReadLine();


        }
    }
}
