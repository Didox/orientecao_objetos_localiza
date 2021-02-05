using System;
using System.Collections.Generic;
using Megocio.Servicos;
using Negocio.Entidades;

namespace ECommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cliente cliente = new Cliente()
            {
                Id = 1,
                Cpf = "999.999.999-99",
                DataNascimento = "03/10/1983",
                Nome = "Patrik Oliveira",
                Telefone = "31-998068050"
            };
            Produto p1 = new Produto()
            {
                Codigo = "1111",
                Descricao = "PRODUTO 1",
                Nome = "PRoduto 1",
                Preco = 99,
            };
            
            Produto p2 = new Produto()
            {
                Codigo = "1222",
                Descricao = "PRODUTO 2",
                Nome = "PRoduto 2",
                Preco = 99,
            };
            List<Produto> produtos = new List<Produto>();
            produtos.Add(p1);
            produtos.Add(p2);


            Pedido pedido = new Pedido()
            {
                Cliente = cliente,
                Date = DateTime.Now,
                Id = 1,
                Produtos = produtos
            };
            Console.WriteLine(pedido.Total);
        }
    }
}