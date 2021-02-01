using System;
using System.Collections.Generic;
using DataBase;

namespace DataBase
{
    public class DbServicesGenerics
    {

        public static void Salvar(IBase iBase){
            
           Console.WriteLine("Estou salvando o carro no banco");

           var campos = iBase.GetType().GetProperties();

           var sql = $"{iBase.GetType().Name.ToLower()}s values(";
           List<string> colunasDb = new List<string>();

           foreach (var campo in campos){
               if(campo.Name.ToLower() != "id"){
                   colunasDb.Add(campo.Name);
               }
           }

           sql += string.Join(",", colunasDb.ToArray());

           sql += ")";

           System.Console.WriteLine(sql);
           
        }
        
    }
}