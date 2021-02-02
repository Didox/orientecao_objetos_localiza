using System;

namespace singleton.Services
{
    public class SmsService
    {
        private SmsService() {}

        private static SmsService _smsService;

        public void Enviar<T>(T obj)
        {
            Console.WriteLine($"Enviando SMS do tipo {obj.GetType().Name}");
        }

        public void Fechar()
        {
            _smsService = null;
        }
        
        public static SmsService Instancia()
        {
            if (_smsService == null)
            {
                _smsService = new SmsService();
            }

            return _smsService;
        }
    }
}