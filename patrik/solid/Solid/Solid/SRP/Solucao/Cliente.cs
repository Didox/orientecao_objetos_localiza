using System;

namespace Solid.SRP.Solucao
{
    public class Cliente
    {
        public Cliente()
        {
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public bool valido()
        {
            return true;
        }
    }
}