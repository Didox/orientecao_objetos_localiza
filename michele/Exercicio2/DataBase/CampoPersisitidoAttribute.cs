using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class CampoPersisitidoAttribute : Attribute
    {
        public string NomeColuna { get; set; }
    }
}
