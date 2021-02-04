using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces.Generics
{
    [Table(Name = "tbl_clientes")]
    public class Cliente : AcoesBancoDeDados<Cliente>
    {
        public Cliente()
        {
        }

        [Table(PrimaryKey = "Codigo")]
        public override int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public bool EnviarSMS()
        {
            Console.WriteLine("Salvando o objeto no banco de dados");
            return true;
        }


        public static List<T> Buscar<T>()
        {
            Console.WriteLine("Buscando lista de clientes");
            return new List<T>();
        }
    }
}
