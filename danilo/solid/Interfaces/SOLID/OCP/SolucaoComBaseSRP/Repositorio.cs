using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces.SOLID.SRP.SolucaoComBaseSRP
{
    public class Repositorio : IRepositorio
    {
        public bool Salvar(ref Cliente cliente, IRepositorioQuery query)
        {
            Console.WriteLine("teste------------");
            try
            {
                Console.WriteLine("Salvando o objeto no banco de dados");
                cliente.Id = Convert.ToInt32(query.Executa("insert into clientes ( ..."));
            }
            catch
            {
                return false;
            }
           
            Console.WriteLine("Salvando o objeto no banco de dados");
            return true;
        }
    }
}
