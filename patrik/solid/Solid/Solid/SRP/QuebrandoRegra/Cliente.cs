using System;
using System.Collections.Generic;

namespace Solid.SRP.QuebrandoRegra
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

        public void Salvar()
        {
            Console.WriteLine("Salvando no Banco de Dados");

            Console.WriteLine("Envia SMS");
            this.EnviarSMS();
        }

        public void EnviarSMS()
        {
            Console.WriteLine("Salvando SMS na fila pra ser enviado");
        }

        public static List<Cliente> Buscar()
        {
            Console.WriteLine("Retornando Lista de Clientes");
            return new List<Cliente>();
        }
    }
}