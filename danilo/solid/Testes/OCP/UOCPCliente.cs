using Interfaces.SOLID.SRP.SolucaoComBaseSRP;
using NUnit.Framework;

namespace Testes.OCP
{
  class RepositorioQueryTest : IRepositorioQuery
  {
        public int Executa(string sql)
        {
            return 1;
        }
  }
  public class USRPCliente
    {
       
        [Test]
        public void SalvandoEntidade()
        {
            var clienteSRP = new Cliente();
            clienteSRP.Nome = "Danilo";
            clienteSRP.Telefone = "123432123";
            clienteSRP.CPF = "123432123";
            clienteSRP.Id = 1;

            Assert.IsTrue(new Repositorio().Salvar(ref clienteSRP, new RepositorioQueryTest()));
        }
    }
}