using Interfaces.SOLID.DIP.Solucao;
using NUnit.Framework;

namespace Testes
{
    public class SmsUTest : ISms
    {
        public string De { get; set; }
        public string Para { get; set; }
        public void Enviar() { }
    }

    public class SmsTeste
    {
        [Test]
        public void EnviarSms()
        {
            var clienteSRP = new Cliente();
            clienteSRP.Nome = "Danilo";
            clienteSRP.Telefone = "123432123";

            ISms smsSender = new SmsUTest();
            //ISms smsSender = new SmsOi();
            var retorno = new Sms().Enviar(clienteSRP, smsSender);

            Assert.IsTrue(retorno);
        }
    }
}