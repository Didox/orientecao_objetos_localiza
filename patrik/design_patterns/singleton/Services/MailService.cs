using System;

namespace singleton.Services
{
    public class MailService
    {
        private MailService() {}

        private static MailService _mailService;

        public void Enviar<T>(T obj)
        {
            Console.WriteLine($"Enviando SMS do tipo {obj.GetType().Name}");
        }

        public void Fechar()
        {
            _mailService = null;
        }
        
        public static MailService Instancia()
        {
            if (_mailService == null)
            {
                _mailService = new MailService();
            }

            return _mailService;
        }
    }
}