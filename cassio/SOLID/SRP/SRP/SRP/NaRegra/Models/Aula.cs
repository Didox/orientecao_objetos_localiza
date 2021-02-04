using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.NaRegra.Models
{
    public class Aula : IAula
    {
        public int Id { get ; set ; }
        public string Nome { get; set; }
        public string Tema { get; set; }
    }
}
