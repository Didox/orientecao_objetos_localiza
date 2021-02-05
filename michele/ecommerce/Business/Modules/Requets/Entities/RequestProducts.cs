using System;
using Business.Modules.Products.Entities;

namespace Business.Modules.Requets.Entities
{
    public class RequestProducts
    {
        public int Id { get; set; }

        public int IdRequest { get; set; }
       
        public Product[] Products{ get; set;}

    }
}