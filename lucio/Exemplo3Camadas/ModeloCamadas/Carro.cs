using DataBaseCamadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloCamadas
{
  public class Carro : BaseService
  {
    [CamposPersistido]
    public string Modelo { get; set; }

    [CamposPersistido]
    public string Marca { get; set; }
  }
}
