using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Interfaces
{
    public interface IAula
    {
        string Nome { get; set; }
        string Tema { get; set; }
        DateTimeOffset HorarioInicio { get; set; }
        DateTimeOffset HorarioFim { get; set; }

    }
}
