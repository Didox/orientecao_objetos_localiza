using System;

namespace Database
{
    public class CampoPersistidoAttribute : Attribute
    {
        public string NomeColuna { get; set; }
    }
}