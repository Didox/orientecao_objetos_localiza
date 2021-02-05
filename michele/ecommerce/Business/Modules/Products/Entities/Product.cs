using System;

namespace Business.Modules.Products.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string SalesUnit { get; set; }

    }
}