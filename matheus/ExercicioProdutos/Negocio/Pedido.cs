using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Registro { get; set; }

        public Cliente Cliente { get; set; }
    }
}
