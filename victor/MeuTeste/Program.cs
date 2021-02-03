using System;
using System.Collections.Generic;

namespace MeuTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoa = new List<Pessoa>();
            listaPessoa.Add(new Pessoa() {Id = 1, Nome = "Victor"});
            listaPessoa.Add(new Pessoa() {Id = 2, Nome = "Felipe"});

            var pessoa = new Pessoa();

            pessoa.Listar();

            foreach (var item in listaPessoa)
            {
                System.Console.WriteLine(item.Nome);
            }

            
        }
    }
}
