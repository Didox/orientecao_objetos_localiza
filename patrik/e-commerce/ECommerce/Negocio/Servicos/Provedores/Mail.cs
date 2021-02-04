namespace Megocio.Servicos.Provedores
{
    public class Mail
    {
        public IServicoEnviar _servicoEnviar;

        public Mail(IServicoEnviar servicoEnviar)
        {
            _servicoEnviar = servicoEnviar;
        }

        public void Enviar(string de, string para, string assunto)
        {
            _servicoEnviar.Enviar();
        }
    }
}