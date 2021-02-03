using System;

namespace Database.Repositories.RequestsReposytory.implementations
{
    public class RequestRepository : IRequestRepository
    {
        public T Create<T>(T request) {
            var newRequest = BaseRepository.Create(request);
            return newRequest;
        }       
        public void Delete<T>(T request)
        {
            BaseRepository.Delete(request);
        }
    }
}