using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCamadas
{
  public class BaseService : Dados
  {
    public override void Salvar()
    {      
      var campos = GetType().GetProperties();
      List<string> colunas = new List<string>();

      string sql = $"insert into {GetType().Name} values(";

      foreach(var campo in campos)
      {
        var camposPersistencia = campo.GetCustomAttribute<CamposPersistidoAttribute>();

        if(camposPersistencia != null)
        {
          var nomeColuna = string.IsNullOrEmpty(camposPersistencia.NomeColuna) ? campo.Name : camposPersistencia.NomeColuna;
          colunas.Add(nomeColuna);
        }        
      }

      sql += string.Join(",", colunas.ToArray());
      sql += ")";

      Console.WriteLine(sql);
    }

    public static string AlterarNomeParaCaixaAlta(string nome)
    {
      return nome.ToUpper();
    }
  }
}
