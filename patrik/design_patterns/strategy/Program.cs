using System;
using Strategy.Modelos.Estrategia1;
using Strategy.Modelos.Implementado;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            new Cliente()
            {
                Nome = "Patrik",
                Telefone = "123456789",
                Cpf = "99999999999",
                Tipo = TipoCliente.Fisica,
            }.Salvar();
            
            new Fisica()
            {
                    Nome = "Patrik",
                    Telefone = "123456789",
                    Cpf = "99999999999",
                    Email = "patrik@gmail.com",
            }.Salvar();
            
            new Juridica()
            {
                Nome = "Patrik",
                Telefone = "123456789",
                Cnpj = "75091228000133",
                Email = "patrik@gmail.com",
                RazaoSocial = "Patrik Solucoes em TI"
            }.Salvar();
            
            new Fornecedor()
            {
                Nome = "Patrik",
                Telefone = "123456789",
                Cnpj = "75091228000133",
                Email = "patrik@gmail.com",
                RazaoSocial = "Patrik Solucoes em TI",
                CodigoCRM = "1234555665"
            }.Salvar();

            foreach (var cliente in Cliente.Todos())
            {
                Console.WriteLine($"Tipo Cliente #{cliente.Tipo}");
            }
            
            foreach (var cliente in ClientesService.Todos())
            {
                Console.WriteLine($"Tipo Cliente #{cliente.GetType().Name}");
            }
        }
    }
}
