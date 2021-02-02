using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    public class AulaVirtual : IAula, IVirtual
    {
        public string Nome { get; set; }
        public string Tema { get; set; }
        public DateTimeOffset HorarioInicio { get; set; }
        public DateTimeOffset HorarioFim { get; set; }
        public string LinkAula { get; set; }
    }
}
