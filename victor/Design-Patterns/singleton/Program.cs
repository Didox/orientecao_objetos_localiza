using singleton.Models.UseCase;
using singleton.Models.Entity;
using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase.Salvar(new Cliente() {
                    Nome = "Victor"
            });
        }
    }
}
