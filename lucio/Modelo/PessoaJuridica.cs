using System;
using Modelo.Cliente;

namespace lucio.Modelo
{
    public class PessoaJuridica : Cliente
    {
        public int CNPJ { get; set; }

        public override void RetornaDadosCliente()
        {
            base.RetornaDadosCliente();
            Console.WriteLine($"CNPJ do Cliente: {CNPJ}");
        }
    }
}