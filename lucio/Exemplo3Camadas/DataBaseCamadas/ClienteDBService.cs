using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCamadas
{
  public class ClienteDBService
  {
    public static void Salvar(IBase iBase)
    {
      var campos = iBase.GetType().GetProperties();
      List<string> colunas = new List<string>();
      string sql = $"insert into {iBase.GetType().Name} values(";

      foreach(var campo in campos)
      {
        var camposPersistencia = campo.GetCustomAttributes<CamposPersistidoAttribute>();

        if(camposPersistencia != null)
        {
          colunas.Add(campo.Name);
        }        
      }

      sql += string.Join(",", colunas.ToArray());
      sql += ")";

      Console.WriteLine(sql);
    }
  }
}
