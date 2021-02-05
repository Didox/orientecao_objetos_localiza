using System;

namespace Business.Services
{
    public class BaseEmailService
    {
        public static void Send<T>(T obj)
        {
            Console.WriteLine($"Sending email for obj of type: {obj.GetType()}");
        }
    }
}
