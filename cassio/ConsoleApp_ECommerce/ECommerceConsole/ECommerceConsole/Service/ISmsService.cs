namespace ECommerceConsole.Service
{
    public interface ISmsService
    {
        void Enviar(string telefone, string mensagem);
    }
}
