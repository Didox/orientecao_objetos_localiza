using System;
using Database;

namespace Negocio
{
    public class Carro : IBase
    {
        public string Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }
}