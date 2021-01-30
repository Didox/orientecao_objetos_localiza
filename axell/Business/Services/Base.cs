using System.Collections.Generic;
using Database.Repositories;

namespace Business.Services
{
    public class BaseService
    {
        public static void Save<T>(T obj)
        {
            BaseRepository.Save(obj);
        }

        public static List<T> List<T>()
        {
            return BaseRepository.List<T>();
        }
    }
}
