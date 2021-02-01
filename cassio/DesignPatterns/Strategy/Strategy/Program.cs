using Strategy.Interfaces;
using Strategy.Models;
using Strategy.Services;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            AulaService.Salvar(new AulaPresencial()
            {
                Nome = "Design Patterns",
                Tema = "Strategy",
                Endereco = "Rua Fulano de Tal, 100",
            });

            AulaService.Salvar(new AulaVirtual()
            {
                Nome = "Design Patterns",
                Tema = "Strategy",
                LinkAula = "www.zoom.com",
                HorarioFim = DateTimeOffset.Now,
            });

            AulaService.Listar<IAula>();

        }
    }
}
