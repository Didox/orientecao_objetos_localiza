using System;
using System.Collections.Generic;

namespace Strategy.Modelos.Estrategia1
{
    public class Cliente
    {

        public int  Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        public TipoCliente Tipo { get; set; }

        public void Salvar()
        {
            if (this.Tipo == TipoCliente.Fisica)
            {
                Console.WriteLine("Salvo no Banco de Dados para pessoa fisica");   
            }
            else if (this.Tipo == TipoCliente.Juridica)
            {
                Console.WriteLine("Salvo no Banco de Dados para pessoa Juridica");
            }
            else if (this.Tipo == TipoCliente.Fornecedor)
            {
                Console.WriteLine("Salvo no Banco de Dados para pessoa Fornecedor");
            }
        }

        public static List<Cliente> Todos()
        {
            return new List<Cliente>();
        }
    }
}