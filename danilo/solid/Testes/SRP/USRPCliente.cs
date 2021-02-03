using Interfaces.SOLID.SRP.Solucao;
using NUnit.Framework;

namespace Testes.SRP
{
    class RepositorioTesteSRP : Repositorio
    {
        public new bool Salvar(ref Cliente cli)
        {
            return true;
        }
    }
    public class USRPCliente
    {
        [Test]
        public void ValidaCamposUsuario()
        {
            var clienteSRP = new Cliente();
            clienteSRP.Nome = "Danilo";
            clienteSRP.Telefone = "123432123";
            clienteSRP.CPF = "123432123";
            clienteSRP.Id = 1;

            Assert.IsTrue(clienteSRP != null);
        }

        [Test]
        public void SalvandoEntidade()
        {
            var clienteSRP = new Cliente();
            clienteSRP.Nome = "Danilo";
            clienteSRP.Telefone = "123432123";
            clienteSRP.CPF = "123432123";
            clienteSRP.Id = 1;

            Assert.IsTrue(new RepositorioTesteSRP().Salvar(ref clienteSRP));
        }
    }
}