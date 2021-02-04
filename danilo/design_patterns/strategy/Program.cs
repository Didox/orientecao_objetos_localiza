using System;
using Strategy.Modelos.Estrategia1;
using Strategy.Modelos.Implementado;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            new Cliente()
            {
                Nome = "Danilo",
                Telefone = "23343333",
                Cpf = "32222222",
                Tipo = TipoCliente.Fisica
            }.Salvar();

            foreach (var cliente in Cliente.Todos())
            {
                Console.WriteLine($"Tipo cliente: #{cliente.Tipo}");
            }

            foreach (var cliente2 in ClientesService.Todos<Fisica>())
            {
                Console.WriteLine($"Tipo cliente: #{cliente2.Cpf}");
            }
        }
    }
}
