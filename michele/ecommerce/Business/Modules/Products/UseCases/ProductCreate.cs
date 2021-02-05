using System;
using Business.Modules.Products.Entities;
using Database.Repositories.ProductRepository;

namespace Business.Modules.Products.UseCases
{
    public class ProductCreate
    {
        public Product Create(Product product, IProductRepository productRepository){
            var newProduct = productRepository.Create(product);
            Console.WriteLine($"Salvando usuário {product.Id}.");

            return newProduct;
        }
    }
}