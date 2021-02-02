using System;

namespace singleton.Services
{
    public class SMSService
    {
        private SMSService()
        {
            openConnection();
        }

        #region Instance methods
        private void openConnection() => Console.WriteLine($"Openning connection for {GetType().Name}");
        private void closeConnection() => Console.WriteLine($"Closing connection for {GetType().Name}");
        public void Send<T>(T obj) => Console.WriteLine($"Sending SMS with object of type: {obj.GetType().Name}");
        #endregion

        #region Static methods
        private static SMSService smsService;

        public static SMSService Get()
        {
            if (smsService == null) smsService = new SMSService();
            return smsService;
        }

        public static void Close()
        {
            if (smsService == null) return;
            smsService.closeConnection();
            smsService = null;
        }
        #endregion
    }
}
