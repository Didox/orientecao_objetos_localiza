using DataBase;
using System;

namespace Negocio
{
    public class Carro : IBase
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }

    }
}
