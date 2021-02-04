namespace Business.Shared.Container.MailProvider.Models
{
    public interface IMailProvider
    {
        void Send(string email);
    }
}