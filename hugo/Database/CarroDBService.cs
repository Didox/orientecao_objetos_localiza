using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class CarroDBService
    {
        public static void Salvar(IBase carro)
        {
            var sql = $"insert into {carro.GetType().Name.ToLower()}s ( ";

            var campos = carro.GetType().GetProperties();
            var camposTabela = new List<string>();

            foreach( var campo in campos)
            {
                camposTabela.Add(campo.Name);
            }

            sql += string.Join(",", camposTabela);
            sql += ")";
            Console.WriteLine(sql);
        }
    }
}