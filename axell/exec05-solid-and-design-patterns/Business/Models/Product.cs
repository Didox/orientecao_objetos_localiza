using Database.Attributes;

namespace Business.Models
{
    [Model(Table = "products")]
    public class Product
    {
        [Pk]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public double Price { get; set; }
    }
}
