namespace Megocio.Servicos.Provedores
{
    public class Sms
    {
        public IServicoEnviar _servicoEnviar;

        public Sms(IServicoEnviar servicoEnviar)
        {
            _servicoEnviar = servicoEnviar;
        }

        public void Enviar(string de, string para, string assunto)
        {
            _servicoEnviar.Enviar();
        }
    }
}