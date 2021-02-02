using System;
using Database;

namespace Negocio
{
    public class Veiculo: IBase
    {
        public string Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public virtual void imprime()
        {
            Console.WriteLine($"{Id}, {Modelo}, {Marca}");
        }
    }
}