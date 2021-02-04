namespace ECommerceConsole.Service
{
    public interface IEmailService
    {
        void Enviar(string telefone, string mensagem);
    }
}
