using System;

namespace singleton.Services
{
    public class EmailService
    {
        private EmailService()
        {
            openConnection();
        }

        #region Instance methods
        private void openConnection() => Console.WriteLine($"Openning connection for {GetType().Name}");
        private void closeConnection() => Console.WriteLine($"Closing connection for {GetType().Name}");
        public void Send<T>(T obj) => Console.WriteLine($"Sending Email with object of type: {obj.GetType().Name}");
        #endregion

        #region Static methods
        private static EmailService emailService;

        public static EmailService Get()
        {
            if (emailService == null) emailService = new EmailService();
            return emailService;
        }

        public static void Close()
        {
            if (emailService == null) return;
            emailService.closeConnection();
            emailService = null;
        }
        #endregion
    }
}
