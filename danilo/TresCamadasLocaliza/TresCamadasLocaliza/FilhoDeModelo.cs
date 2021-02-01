using System;
using System.Collections.Generic;
using Database;

namespace Negocio
{
    public class FilhoDeModelo : Modelo
    {
        public string Sobrenome { get; set; }

        public sealed override void Salvar()
        {
            base.Salvar();
        }

    }
}