using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public class Fisica : Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }

        public sealed override void Salvar()
        {
            base.Salvar();
        }

    }
}
