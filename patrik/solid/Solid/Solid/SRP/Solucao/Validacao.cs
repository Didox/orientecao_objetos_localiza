using System;

namespace Solid.SRP.Solucao
{
    public class Validacao
    {
        public void Validar(Cliente cliente)
        {
            Console.WriteLine("Validando cliente");

            throw new Exception("Cliente inválido");
        }
    }
}