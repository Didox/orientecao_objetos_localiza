using System.Collections.Generic;

namespace Database.Repositories
{
    public class NonGenericBaseRepository
    {
        public static void Save(object obj)
        {
            BaseRepository.Save(obj);
        }

        public static List<object> List()
        {
            return new List<object>();
        }
    }
}
