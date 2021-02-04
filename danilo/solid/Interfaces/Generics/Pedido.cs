using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces.Generics
{
    public class Pedido : AcoesBancoDeDados<Pedido>
    {
        public Pedido()
        {
        }

        public double ValorTotal { get; set; }
    }
}
