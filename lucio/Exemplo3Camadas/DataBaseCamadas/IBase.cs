using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCamadas
{
  public interface IBase
  {
    int Id { get; set; }

    void Salvar();
  }

}
