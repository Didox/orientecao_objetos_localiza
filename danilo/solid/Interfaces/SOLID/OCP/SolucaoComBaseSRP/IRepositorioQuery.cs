using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces.SOLID.SRP.SolucaoComBaseSRP
{
    public interface IRepositorioQuery
    {
        int Executa(string sql);
    }
}
