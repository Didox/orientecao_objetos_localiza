using System;

namespace Database.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        T Create<T>(T client);
        void Delete<T>(T obj);
        
    }
}