using System;
using System.Collections.Generic;

public class CarroDBService
{
    public static void Salvar(IBase iBase) {

        Console.Write("Salvando carro.");

        var campos = iBase.GetType().GetProperties();

        List<String> colunas = new List<string>();
        string sql = $"insert into{iBase.GetType().Name} values(";

        foreach(var campo in campos) {
            colunas.Add(campo.Name);

        }
        sql += string.Join(",", colunas.ToArray());
        sql += ")";
    
    }

}
