using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces.SOLID.SRP.SolucaoComBaseSRP
{
    public interface IRepositorio
    {
        bool Salvar(ref Cliente cliente, IRepositorioQuery query);
    }
}
