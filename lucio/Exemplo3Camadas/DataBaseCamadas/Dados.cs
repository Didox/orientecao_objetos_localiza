using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCamadas
{
  public abstract class Dados : IBase
  { 
    [Pk]
    public int Id { get; set; }

    public abstract void Salvar();
  }
}
