using System;
using Business.Modules.Products.Entities;
using Database.Repositories.ProductRepository;

namespace Business.Modules.Products.UseCases
{
    public class ProductDelete
    {
        public void Delete<Product>(Product obj, IProductRepository productRepository){
            productRepository.Delete(obj);
            Console.WriteLine($"Excluindo usuário.");
        }
    }
}