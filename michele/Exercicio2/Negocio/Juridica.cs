﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class Juridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
    }
}
