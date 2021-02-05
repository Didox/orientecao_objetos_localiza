using System;

namespace Business.Services
{
    public class BaseSMSService
    {
        public static void Send<T>(T obj)
        {
            Console.WriteLine($"Sending SMS for obj of type: {obj.GetType()}");
        }
    }
}
