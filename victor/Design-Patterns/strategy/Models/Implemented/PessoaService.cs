using System;
using System.Collections.Generic;

namespace strategy.Models.Implemented
{
    public class PessoaService
    {
        public static void Salvar<T>(T data)
        {
            Console.WriteLine($"Salvando na tabela {data.GetType().Name}");
        }

        public static List<IPessoa> Listar()
        {
            System.Console.WriteLine("LISTANDO PESSOAS");
            return new List<IPessoa>();
        }
    }
}