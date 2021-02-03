namespace Business.Shared.Container.SmsProvider.Models
{
    public interface ISmsProvider
    {
        bool Send(string sms);
    }
}