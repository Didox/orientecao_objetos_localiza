using System.Collections.Generic;
using Database.Repositories;

namespace Business.Services
{
    public class NonGenericBaseService
    {
        public static void Save(object obj)
        {
            NonGenericBaseRepository.Save(obj);
        }

        public static List<object> List()
        {
            return NonGenericBaseRepository.List();
        }
    }
}
