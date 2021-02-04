using System;

namespace Business.Services
{
    public class BaseFileCrudService
    {
        public static void Save<T>(T obj)
        {
            Console.WriteLine($"Saving object of type: {obj.GetType()} into a file");
        }
    }
}
