using Interfaces.SOLID.DIP.Solucao;
using NUnit.Framework;

namespace Testes
{
    public class RepositorioUTest : IRepositorio
    {
        public bool Salvar(ref Cliente cliente)
        {
            return true;
        }
    }

    public class RepositorioTeste
    {
        [Test]
        public void EnviarSms()
        {
            var clienteSRP = new Cliente();
            clienteSRP.Nome = "Danilo";
            clienteSRP.Telefone = "123432123";

            new Validacao().Validar(clienteSRP);

            IRepositorio repo = new RepositorioUTest();
            var retorno = repo.Salvar(ref clienteSRP);

            Assert.IsTrue(retorno);
        }
    }
}