using System;

namespace Business.Services
{
    public class BaseGatewayService
    {
        public static void Pay<T>(T obj)
        {
            Console.WriteLine($"Using payment gateway for obj of type: {obj.GetType()}");
        }
    }
}
