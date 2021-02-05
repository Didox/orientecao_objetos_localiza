using System.Collections.Generic;
using Database.Repositories;

namespace Business.Services
{
    public class BaseCrudService
    {
        public static void Save<T>(T obj)
        {
            BaseRepository.Save(obj);
        }
    }
}
