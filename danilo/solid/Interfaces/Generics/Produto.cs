using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces.Generics
{
    public class Produto : AcoesBancoDeDados<Produto>
    {
        public Produto()
        {
        }

        public string Nome { get; set; }
    }
}
