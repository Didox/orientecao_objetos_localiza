using System;

namespace Database.Repositories.RequestsReposytory
{
    public interface IRequestRepository
    {
        T Create<T>(T request);        
        void Delete<T>(T request);

    }
}