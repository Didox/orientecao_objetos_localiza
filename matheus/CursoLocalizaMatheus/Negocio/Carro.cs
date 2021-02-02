using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class Carro : IBase
    {
        [Pk]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        [CampoPersistido]
        public int Descricao { get; set; }

    }
}
